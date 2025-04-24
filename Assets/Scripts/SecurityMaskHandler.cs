using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecurityMaskHandler : MonoBehaviour
{
    public GameObject canvasMask; // 面罩控制Canvas
    public TextMeshProUGUI textTitle; // 标题文本
    public TextMeshProUGUI textContext; // 正文文本
    public Image image; // 第一个图片
    public Image image1; // 第二个图片

    private void Start()
    {
        // 确保Canvas初始是隐藏的
        if (canvasMask != null)
        {
            canvasMask.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家
        {
            // 显示Canvas
            if (canvasMask != null)
            {
                canvasMask.SetActive(true); // 显示Canvas
            }

            // 设置标题文本
            if (textTitle != null)
            {
                textTitle.text = "Wearing masks to prevent air pollution damage";
                textTitle.gameObject.SetActive(true); // 显示标题文本
            }

            // 设置正文文本
            if (textContext != null)
            {
                textContext.text = "Factory environments may contain dust or hazardous gases that can be harmful to health if inhaled for long periods of time. Workers should wear protective masks correctly, choose the type suitable for the environment and replace them regularly. At the same time, maintain good ventilation to reduce sources of pollution and protect your health.";
                textContext.gameObject.SetActive(true); // 显示正文文本
            }

            // 显示第一个图片
            if (image != null)
            {
                image.gameObject.SetActive(true); // 显示第一个图片
            }

            // 显示第二个图片
            if (image1 != null)
            {
                image1.gameObject.SetActive(true); // 显示第二个图片
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，隐藏Canvas
            if (canvasMask != null)
            {
                canvasMask.SetActive(false); // 隐藏Canvas
            }

            // 隐藏标题文本
            if (textTitle != null)
            {
                textTitle.gameObject.SetActive(false); // 隐藏标题文本
            }

            // 隐藏正文文本
            if (textContext != null)
            {
                textContext.gameObject.SetActive(false); // 隐藏正文文本
            }

            // 隐藏第一个图片
            if (image != null)
            {
                image.gameObject.SetActive(false); // 隐藏第一个图片
            }

            // 隐藏第二个图片
            if (image1 != null)
            {
                image1.gameObject.SetActive(false); // 隐藏第二个图片
            }
        }
    }
}
