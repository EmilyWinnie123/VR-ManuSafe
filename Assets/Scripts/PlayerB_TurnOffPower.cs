// PlayerB_TurnOffPower.cs
using UnityEngine;

public class PlayerB_TurnOffPower : MonoBehaviour
{
    private bool mPressed = false; // 标记 M 键是否已被按下

    void Update()
    {
        // 检查是否处于等待断电阶段
        if (GameManager.Instance.CurrentPhase == GameManager.GamePhase.WaitingForPowerOff)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                mPressed = true;
                GameManager.Instance.OnPlayerBTurnedOffPower();
                // 注意：OnPlayerBTurnedOffPower 会将状态改为 PlayerBSwitchingBack
            }
        }
        // 检查是否处于 Player B 切换阶段，并且 M 键已经被按下过
        else if (GameManager.Instance.CurrentPhase == GameManager.GamePhase.PlayerBSwitchingBack && mPressed)
        {
            if (Input.GetKeyDown(KeyCode.B)) // 注意：这里监听的是 B 键
            {
                mPressed = false; // 重置标记
                GameManager.Instance.SwitchControlToPlayerA();
            }
        }
        // 可选：如果在任何时候按了 M 但不在正确阶段，可以重置标记
        // else if (Input.GetKeyDown(KeyCode.M))
        // {
        //     mPressed = false;
        // }
    }
}
