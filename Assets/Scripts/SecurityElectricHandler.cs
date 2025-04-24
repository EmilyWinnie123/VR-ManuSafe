using UnityEngine;
using TMPro; // 引入TextMesh Pro命名空间
using UnityEngine.UI; // 引入UI命名空间
using System.Collections;

public class SecurityElectricHandler : MonoBehaviour
{
    public GameObject electricCanvas; // 电区域Canvas
    public TextMeshProUGUI textTittle; // 标题文本
    public TextMeshProUGUI textContext; // 正文文本
    public Image chudianImage; // 第一个图片
    public Image logoImage; // 第二个图片

    private void Start()
    {
        // 确保电区域Canvas初始是隐藏的
        if (electricCanvas != null)
        {
            electricCanvas.SetActive(false);
        }

        // 确保标题文本初始是隐藏的
        if (textTittle != null)
        {
            textTittle.gameObject.SetActive(false);
        }

        // 确保正文文本初始是隐藏的
        if (textContext != null)
        {
            textContext.gameObject.SetActive(false);
        }

        // 确保第一个图片初始是隐藏的
        if (chudianImage != null)
        {
            chudianImage.gameObject.SetActive(false);
        }

        // 确保第二个图片初始是隐藏的
        if (logoImage != null)
        {
            logoImage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家
        {
            // 启动协程，在1秒后显示电区域Canvas
            StartCoroutine(ShowElectricCanvasAfterDelay());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，立即隐藏电区域Canvas
            HideElectricCanvas();
        }
    }

    private IEnumerator ShowElectricCanvasAfterDelay()
    {
        yield return new WaitForSeconds(1f); // 等待1秒

        // 显示电区域Canvas
        if (electricCanvas != null)
        {
            electricCanvas.SetActive(true); // 显示Canvas
        }

        // 显示标题文本
        if (textTittle != null)
        {
            textTittle.text = "Safety Precautions for Electric Shock.";
            textTittle.gameObject.SetActive(true); // 显示标题文本
        }

        // 显示正文文本
        if (textContext != null)
        {
            textContext.text = "Stay Away: Do not touch the electrical box or nearby areas.\n" +
                               "Turn Off Power: Cut off the main power supply immediately.\n" +
                               "Warn Others: Inform others to stay away from the area.\n" +
                               "Call a Professional: Contact a licensed electrician to fix the issue.\n" +
                               "Avoid Water: Keep the area dry and avoid stepping in water near the box.\n" +
                               "Use Insulated Tools: If necessary, only use insulated tools for any action.";
            textContext.gameObject.SetActive(true); // 显示正文文本
        }

        // 显示第一个图片
        if (chudianImage != null)
        {
            chudianImage.gameObject.SetActive(true); // 显示第一个图片
        }

        // 显示第二个图片
        if (logoImage != null)
        {
            logoImage.gameObject.SetActive(true); // 显示第二个图片
        }
    }

    private void HideElectricCanvas()
    {
        // 隐藏电区域Canvas
        if (electricCanvas != null)
        {
            electricCanvas.SetActive(false); // 隐藏Canvas
        }

        // 隐藏标题文本
        if (textTittle != null)
        {
            textTittle.gameObject.SetActive(false); // 隐藏标题文本
        }

        // 隐藏正文文本
        if (textContext != null)
        {
            textContext.gameObject.SetActive(false); // 隐藏正文文本
        }

        // 隐藏第一个图片
        if (chudianImage != null)
        {
            chudianImage.gameObject.SetActive(false); // 隐藏第一个图片
        }

        // 隐藏第二个图片
        if (logoImage != null)
        {
            logoImage.gameObject.SetActive(false); // 隐藏第二个图片
        }
    }
}