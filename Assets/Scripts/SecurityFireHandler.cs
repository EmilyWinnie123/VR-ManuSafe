using UnityEngine;
using TMPro; // 引入TextMesh Pro命名空间
using UnityEngine.UI; // 引入UI命名空间
using System.Collections;

public class SecurityFireHandler : MonoBehaviour
{
    public GameObject fireCanvas; // 火灾区域Canvas
    public TextMeshProUGUI textTitle; // 标题文本
    public TextMeshProUGUI textContext; // 正文文本
    public Image safetyStepImage; // 安全步骤图片
    public Image fireExtinguisherDescriptionImage; // 灭火器描述图片
    public Image fireActionImage; // 火灾行动图片

    private void Start()
    {
        // 确保火灾区域Canvas初始是隐藏的
        if (fireCanvas != null)
        {
            fireCanvas.SetActive(false);
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

        // 确保安全步骤图片初始是隐藏的
        if (safetyStepImage != null)
        {
            safetyStepImage.gameObject.SetActive(false);
        }

        // 确保灭火器描述图片初始是隐藏的
        if (fireExtinguisherDescriptionImage != null)
        {
            fireExtinguisherDescriptionImage.gameObject.SetActive(false);
        }

        // 确保火灾行动图片初始是隐藏的
        if (fireActionImage != null)
        {
            fireActionImage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家
        {
            // 启动协程，在1.5秒后显示火灾区域Canvas
            StartCoroutine(ShowFireCanvasAfterDelay());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，立即隐藏火灾区域Canvas
            HideFireCanvas();
        }
    }

    private IEnumerator ShowFireCanvasAfterDelay()
    {
        yield return new WaitForSeconds(1.5f); // 等待1.5秒

        // 显示火灾区域Canvas
        if (fireCanvas != null)
        {
            fireCanvas.SetActive(true); // 显示Canvas
        }

        // 显示标题文本
        if (textTitle != null)
        {
            textTitle.text = "Fire Safety and Emergency Operations Guide";
            textTitle.gameObject.SetActive(true); // 显示标题文本
        }

        // 显示正文文本
        if (textContext != null)
        {
            textContext.text =  "Fire is relentless and prevention is as important\n" +
              "as emergency response. This guide covers\n" +
              "workplace fire inspections, fire emergency\n" +
              "response actions, and passive fire prevention\n" +
              "measures to help promote safety awareness.\n" +
              "Quick response and correct evacuation are key\n" +
              "in a fire. Get alarm, escape and assembly point\n" +
              "guidelines to buy time for life and safety.";

            textContext.gameObject.SetActive(true); // 显示正文文本
        }

        // 显示安全步骤图片
        if (safetyStepImage != null)
        {
            safetyStepImage.gameObject.SetActive(true); // 显示安全步骤图片
        }

        // 显示灭火器描述图片
        if (fireExtinguisherDescriptionImage != null)
        {
            fireExtinguisherDescriptionImage.gameObject.SetActive(true); // 显示灭火器描述图片
        }

        // 显示火灾行动图片
        if (fireActionImage != null)
        {
            fireActionImage.gameObject.SetActive(true); // 显示火灾行动图片
        }
    }

    private void HideFireCanvas()
    {
        // 隐藏火灾区域Canvas
        if (fireCanvas != null)
        {
            fireCanvas.SetActive(false); // 隐藏Canvas
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

        // 隐藏安全步骤图片
        if (safetyStepImage != null)
        {
            safetyStepImage.gameObject.SetActive(false); // 隐藏安全步骤图片
        }

        // 隐藏灭火器描述图片
        if (fireExtinguisherDescriptionImage != null)
        {
            fireExtinguisherDescriptionImage.gameObject.SetActive(false); // 隐藏灭火器描述图片
        }

        // 隐藏火灾行动图片
        if (fireActionImage != null)
        {
            fireActionImage.gameObject.SetActive(false); // 隐藏火灾行动图片
        }
    }
}