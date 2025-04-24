using UnityEngine;
using TMPro; // 引入TextMesh Pro命名空间
using UnityEngine.UI; // 引入UI命名空间

public class SecurityZoneHandler : MonoBehaviour
{
    public GameObject securityZoneCanvas; // 安全区域Canvas
    public TextMeshProUGUI textTittle;    // 标题文本
    public TextMeshProUGUI textContext;   // 正文文本
    public Image shuaidaoImage;           // 第一个图片
    public Image logoImage;               // 第二个图片

    private void Start()
    {
        // 确保安全区域Canvas初始是隐藏的
        if (securityZoneCanvas != null)
        {
            securityZoneCanvas.SetActive(false);
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
        if (shuaidaoImage != null)
        {
            shuaidaoImage.gameObject.SetActive(false);
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
            // 显示安全区域Canvas
            if (securityZoneCanvas != null)
            {
                securityZoneCanvas.SetActive(true); // 显示Canvas
            }

            // 显示标题文本
            if (textTittle != null)
            {
                textTittle.text = "Please walk in the green safety zone.";
                textTittle.gameObject.SetActive(true); // 显示标题文本
            }

            // 显示正文文本
            if (textContext != null)
            {
                textContext.text = "All personnel must walk within the green line and avoid hazardous or equipment work areas to ensure safety and protect themselves from injury.\nPotential Risks:\n1. Mechanical Injuries: Misadventure into areas where machines are operating increases the risk of being caught or strangled by the equipment.\n2. Collision Injury: Collision with conveyor belts and work equipment may occur in non-designated areas.\n3. Falls/Slips: Failure to follow directions increases the likelihood of an accidental fall.";
                textContext.gameObject.SetActive(true); // 显示正文文本
            }

            // 显示第一个图片
            if (shuaidaoImage != null)
            {
                shuaidaoImage.gameObject.SetActive(true); // 显示第一个图片
            }

            // 显示第二个图片
            if (logoImage != null)
            {
                logoImage.gameObject.SetActive(true); // 显示第二个图片
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 当玩家离开触发区时，隐藏安全区域Canvas
            if (securityZoneCanvas != null)
            {
                securityZoneCanvas.SetActive(false); // 隐藏Canvas
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
            if (shuaidaoImage != null)
            {
                shuaidaoImage.gameObject.SetActive(false); // 隐藏第一个图片
            }

            // 隐藏第二个图片
            if (logoImage != null)
            {
                logoImage.gameObject.SetActive(false); // 隐藏第二个图片
            }
        }
    }
}