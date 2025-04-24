using UnityEngine;
using TMPro;
using System.Collections;

public class FireHandler : MonoBehaviour
{
    public GameObject fire; // 火焰特效的游戏对象
    public TMP_Text safetyTips; // 安全提示文本
    public AudioSource fireSound; // 新增：火焰音效

    private void Start()
    {
        // 确保火焰特效初始是隐藏的
        if (fire != null)
        {
            fire.SetActive(false);
        }

        // 确保提示文字初始是隐藏的
        if (safetyTips != null)
        {
            safetyTips.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家
        {
            // 播放火焰音效
            if (fireSound != null)
            {
                fireSound.Play();
            }

            // 启动火焰特效
            if (fire != null)
            {
                fire.SetActive(true); // 显示特效
                var particleSystem = fire.GetComponent<ParticleSystem>();
                if (particleSystem != null)
                {
                    particleSystem.Play(); // 播放特效
                }
            }

            // 显示安全提示
            if (safetyTips != null)
            {
                // 设置提示文字
                safetyTips.text = "Fire is ruthless, safety comes first!";
                safetyTips.gameObject.SetActive(true); // 显示提示文字

                // 启动协程，在1秒后隐藏提示文字
                StartCoroutine(HideSafetyTipsAfterDelay());
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，停止播放火焰特效
            if (fire != null)
            {
                var particleSystem = fire.GetComponent<ParticleSystem>();
                if (particleSystem != null)
                {
                    particleSystem.Stop(); // 停止播放特效
                }
                fire.SetActive(false); // 隐藏特效
            }

            // 隐藏安全提示
            if (safetyTips != null)
            {
                safetyTips.gameObject.SetActive(false); // 隐藏提示文字
            }
        }
    }

    private IEnumerator HideSafetyTipsAfterDelay()
    {
        yield return new WaitForSeconds(1f); // 等待1秒

        // 隐藏提示文字
        if (safetyTips != null)
        {
            safetyTips.gameObject.SetActive(false); // 隐藏提示文字
        }
    }
}