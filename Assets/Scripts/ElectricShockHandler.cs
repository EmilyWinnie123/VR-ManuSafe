using UnityEngine;
using TMPro; // 引入TextMesh Pro命名空间
using System.Collections;

public class ElectricShockHandler : MonoBehaviour
{
    public GameObject electricSpark; // 电火花特效的游戏对象
    public AudioSource shockSound;   // 电击音效
    public TMP_Text safetyTips;      // 使用Text Mesh Pro的安全提示文本

    private void Start()
    {
        // 确保电火花特效初始是隐藏的
        if (electricSpark != null)
        {
            electricSpark.SetActive(false);
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
            // 播放电击音效
            if (shockSound != null)
            {
                shockSound.Play();
            }

            // 启动电火花特效
            if (electricSpark != null)
            {
                electricSpark.SetActive(true); // 显示特效
                var particleSystem = electricSpark.GetComponent<ParticleSystem>();
                if (particleSystem != null)
                {
                    particleSystem.Play(); // 播放特效
                }
            }

            // 显示安全提示
            if (safetyTips != null)
            {
                // 显示初始警告信息
                safetyTips.text = "Caution! Do not touch electrically charged objects!";
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
            // 当玩家离开触发区时，停止播放电火花特效
            if (electricSpark != null)
            {
                var particleSystem = electricSpark.GetComponent<ParticleSystem>();
                if (particleSystem != null)
                {
                    particleSystem.Stop(); // 停止播放特效
                }
                electricSpark.SetActive(false); // 隐藏特效
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
        yield return new WaitForSeconds(0.75f); // 等待1秒

        // 隐藏提示文字
        if (safetyTips != null)
        {
            safetyTips.gameObject.SetActive(false); // 隐藏提示文字
        }
    }
}