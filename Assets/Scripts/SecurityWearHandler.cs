using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecurityWearHandler : MonoBehaviour
{
    public Canvas securityWearCanvas; // 安全区域Canvas
    public TextMeshProUGUI textTitle; // 标题文本
    public TextMeshProUGUI textContext; // 正文文本
    public Image peopleImage; // 人物图片
    public Image harmImage; // 危害图片

    private void Start()
    {
        // 确保安全区域Canvas初始是隐藏的
        if (securityWearCanvas != null)
        {
            securityWearCanvas.gameObject.SetActive(false);
        }

        // 确保标题文本初始是隐藏的
        if (textTitle != null)
        {
            textTitle.gameObject.SetActive(false);
        }

        // 确保正文文本初始是隐藏的
        if (textContext != null)
        {
            textContext.gameObject.SetActive(false);
        }

        // 确保人物图片初始是隐藏的
        if (peopleImage != null)
        {
            peopleImage.gameObject.SetActive(false);
        }

        // 确保危害图片初始是隐藏的
        if (harmImage != null)
        {
            harmImage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家
        {
            // 显示安全区域Canvas
            if (securityWearCanvas != null)
            {
                securityWearCanvas.gameObject.SetActive(true); // 显示Canvas
            }

            // 显示标题文本
            if (textTitle != null)
            {
                textTitle.text = "Please wear appropriate safety gear.";
                textTitle.gameObject.SetActive(true); // 显示标题文本
            }

            // 显示正文文本
            if (textContext != null)
            {
                textContext.text = "Correctly wearing labour protection shoes and PPE\n helmets can effectively prevent common accidents\n such as injuries caused by heavy objects, slips and\n falls and head impacts, providing workers with\n comprehensive safety protection.";
                textContext.gameObject.SetActive(true); // 显示正文文本
            }

            // 显示人物图片
            if (peopleImage != null)
            {
                peopleImage.gameObject.SetActive(true); // 显示人物图片
            }

            // 显示危害图片
            if (harmImage != null)
            {
                harmImage.gameObject.SetActive(true); // 显示危害图片
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，隐藏安全区域Canvas
            if (securityWearCanvas != null)
            {
                securityWearCanvas.gameObject.SetActive(false); // 隐藏Canvas
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

            // 隐藏人物图片
            if (peopleImage != null)
            {
                peopleImage.gameObject.SetActive(false); // 隐藏人物图片
            }

            // 隐藏危害图片
            if (harmImage != null)
            {
                harmImage.gameObject.SetActive(false); // 隐藏危害图片
            }
        }
    }
}