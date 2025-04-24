using UnityEngine;
using TMPro; // 引入TextMesh Pro命名空间
using UnityEngine.UI; // 引入UI命名空间

public class SecurityConveyorHandler : MonoBehaviour
{
    public GameObject securityZoneCanvas; // 安全区域Canvas
    public TextMeshProUGUI textTitle;    // 标题文本
    public TextMeshProUGUI textContext;  // 正文文本
    public Image image1;                 // 第一个图片
    public Image image2;                 // 第二个图片

    private void Start()
    {
        // 确保安全区域Canvas初始是隐藏的
        if (securityZoneCanvas != null)
        {
            securityZoneCanvas.SetActive(false);
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

        // 确保第一个图片初始是隐藏的
        if (image1 != null)
        {
            image1.gameObject.SetActive(false);
        }

        // 确保第二个图片初始是隐藏的
        if (image2 != null)
        {
            image2.gameObject.SetActive(false);
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
            if (textTitle != null)
            {
                textTitle.text = "Safety Points for Factory Conveyor Belt Operation";
                textTitle.gameObject.SetActive(true); // 显示标题文本
            }

            // 显示正文文本
            if (textContext != null)
            {
                textContext.text = "1. Pre-operation inspection:\nMake sure the conveyor belt is free of damage and obstacles.\nCheck whether the guards are normal.\n\n2. Correct operation:\nMake sure no one is near the conveyor before starting.\nDo not touch the running conveyor.\nAdjust the speed and direction according to the regulations.\n\n3. Caution:\nDo not wear loose clothing and keep away from dangerous areas.\nKeep area clean and tidy to prevent slipping.\n\n4. Emergency Handling:\nFamiliarise yourself with the location of the emergency stop button.\nStop the machine immediately and report any abnormalities.";
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
            // 当玩家离开触发区时，隐藏安全区域Canvas
            if (securityZoneCanvas != null)
            {
                securityZoneCanvas.SetActive(false); // 隐藏Canvas
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
