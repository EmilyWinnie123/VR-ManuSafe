using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecurityNoiceorHandler : MonoBehaviour
{
    public GameObject canvasNoice; // 噪音控制Canvas
    public TextMeshProUGUI textTitle; // 标题文本
    public TextMeshProUGUI textContext; // 正文文本
    public Image image1; // 第一个图片
    public Image image2; // 第二个图片

    private void Start()
    {
        // 确保Canvas初始是隐藏的
        if (canvasNoice != null)
        {
            canvasNoice.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家
        {
            // 显示Canvas
            if (canvasNoice != null)
            {
                canvasNoice.SetActive(true); // 显示Canvas
            }

            // 设置标题文本
            if (textTitle != null)
            {
                textTitle.text = "Factory Noise Control and Safety";
                textTitle.gameObject.SetActive(true); // 显示标题文本
            }

            // 设置正文文本
            if (textContext != null)
            {
                textContext.text = "Reduce the spread of noise by using soundproofing equipment and silencing materials.\nRegularly maintain machinery and equipment to avoid additional noise due to ageing or malfunctioning.\nProvide earplugs or ear muffs to protect workers' hearing and reduce the impact of noise.";
                textContext.gameObject.SetActive(true); // 显示正文文本
            }

            // 显示第一个图片
            if (image1 != null)
            {
                image1.gameObject.SetActive(true); // 显示第一个图片
            }

            // 显示第二个图片
            if (image2 != null)
            {
                image2.gameObject.SetActive(true); // 显示第二个图片
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，隐藏Canvas
            if (canvasNoice != null)
            {
                canvasNoice.SetActive(false); // 隐藏Canvas
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
            if (image1 != null)
            {
                image1.gameObject.SetActive(false); // 隐藏第一个图片
            }

            // 隐藏第二个图片
            if (image2 != null)
            {
                image2.gameObject.SetActive(false); // 隐藏第二个图片
            }
        }
    }
}