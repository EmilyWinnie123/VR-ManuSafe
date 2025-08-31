// GameManager.cs
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GamePhase
    {
        WaitingForShock,        // 等待玩家A触电触发
        ShockDemo,              // 正在进行触电演示
        WaitingForHelp,         // 触电演示结束，等待玩家A请求帮助
        WaitingForPowerOff,     // 玩家A已请求帮助，等待玩家B断电
        PlayerBSwitchingBack,   // 玩家B断电后，等待切换回玩家A (新增)
        CollaborationComplete   // 协作完成
    }

    public GamePhase CurrentPhase { get; private set; } = GamePhase.WaitingForShock;

    public TextMeshProUGUI messageText;
    public ElectricShockHandler electricShockHandler; // 引用触电处理脚本

    // 假设这是 Player A 的请求帮助脚本引用，需要在 Inspector 中赋值
    public PlayerA_RequestHelp playerARequestHelpScript;
    // 假设这是 Player B 的断电脚本引用，需要在 Inspector 中赋值
    public PlayerB_TurnOffPower playerBTurnOffPowerScript;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        if (messageText != null)
        {
            // 显示初始提示
            messageText.gameObject.SetActive(true);
            messageText.text = "Player A, please touch the electrical equipment to start the demonstration.";

            // 5秒后自动隐藏
            Invoke("HideMessage", 5f);
        }
    }

    // 简单的隐藏方法
    private void HideMessage()
    {
        if (messageText != null)
        {
            messageText.gameObject.SetActive(false);
        }
    }

    public void OnPlayerAShocked()
    {
        // 演示结束，进入等待帮助阶段
        CurrentPhase = GamePhase.WaitingForHelp;
        Debug.Log("Player A shocked. Waiting for help request.");
        Invoke("ShowWarningMessage", 5f); // 5秒后显示请求帮助信息
    }

    private void ShowWarningMessage()
    {
        if (CurrentPhase == GamePhase.WaitingForHelp) // 确保状态仍是等待帮助
        {
             UpdateMessage("The electric shock accident has been demonstrated!\nA simulated fire is about to occur.\nPlayer A, press [B] to call Player B for assistance.");
        }
    }

    // 由 PlayerA_RequestHelp 脚本调用
    public void OnPlayerARequestedHelp()
    {
        if (CurrentPhase != GamePhase.WaitingForHelp) return; // 确保在正确阶段

        CurrentPhase = GamePhase.WaitingForPowerOff;
        Debug.Log("Player A requested help.");
        UpdateMessage(" Player B, please press [M] to cut off the power and prevent fire!");
    }

    // 由 PlayerB_TurnOffPower 脚本调用
    public void OnPlayerBTurnedOffPower()
    {
        if (CurrentPhase != GamePhase.WaitingForPowerOff) return; // 确保在正确阶段

        // 执行断电
        if (electricShockHandler != null)
        {
            electricShockHandler.ForceTurnOffElectricity();
        }
        else
        {
            Debug.LogError("ElectricShockHandler not assigned in GameManager!");
        }

        // 进入 Player B 切换阶段
        CurrentPhase = GamePhase.PlayerBSwitchingBack;
        Debug.Log("Power successfully turned off by Player B! Now press [B] to switch back to Player A.");
        UpdateMessage("Power has been cut off! Fire risk eliminated.\nPlayer B, press [B] to switch control back to Player A.");

        // 可以在这里添加逻辑来准备切换，例如启用一个专门用于切换的脚本
        // 或者直接在 PlayerB_TurnOffPower 脚本中处理后续逻辑
    }

    // 新增：由 PlayerB_TurnOffPower 脚本在切换阶段调用
    public void SwitchControlToPlayerA()
    {
        if (CurrentPhase != GamePhase.PlayerBSwitchingBack) return;

        Debug.Log("Switching control back to Player A.");
        UpdateMessage("Control returned to Player A. Collaboration completed.");

        // 实际的控制权切换逻辑
        // 1. 禁用 Player B 的脚本 (或使其不再响应 M/B)
        if (playerBTurnOffPowerScript != null)
        {
            playerBTurnOffPowerScript.enabled = false; // 或者调用其内部方法禁用监听
        }

        // 2. 启用 Player A 的脚本 (如果之前被禁用) 或通知其可以操作
        //    这里假设 PlayerA_RequestHelp 脚本负责监听 B 键，它可能需要被重新启用或通知
        if(playerARequestHelpScript != null)
        {
             // playerARequestHelpScript.enabled = true; // 如果需要启用
             // 或者如果有方法通知它，例如：
             // playerARequestHelpScript.OnControlReturned();
        }

        // 3. 更新游戏阶段
        CurrentPhase = GamePhase.CollaborationComplete;
        // 可以在这里添加更多完成后的逻辑，比如播放成功音效、解锁成就等
    }


    private void UpdateMessage(string message)
    {
         if (messageText != null)
        {
            messageText.gameObject.SetActive(true);
            messageText.text = message;
        }
    }
}

