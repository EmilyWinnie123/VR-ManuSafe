using UnityEngine;
using TMPro; // 引入TextMesh Pro命名空间
using UnityEngine.UI; // 引入UI命名空间

public class SecurityMachineHandler : MonoBehaviour
{
    public GameObject securityZoneCanvas; // 安全区域Canvas
    public TextMeshProUGUI textTitle;    // 标题文本
    public TextMeshProUGUI textContext1; // 正文文本1
    public TextMeshProUGUI textContext2; // 正文文本2
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

        // 确保正文文本1初始是隐藏的
        if (textContext1 != null)
        {
            textContext1.gameObject.SetActive(false);
        }

        // 确保正文文本2初始是隐藏的
        if (textContext2 != null)
        {
            textContext2.gameObject.SetActive(false);
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
                textTitle.text = "Key points to prevent robotic arm injuries";
                textTitle.gameObject.SetActive(true); // 显示标题文本
            }

            // 显示正文文本1
            if (textContext1 != null)
            {
                textContext1.text = "1. Risk of injury from robotic arms\nCommon risks: crushing, collision, pinching.\nHigh risk areas: range of motion of the robotic arm and the end tool.\n\n2. Correct operation specification\nObserve the operation procedure and stay away from the range of motion of the robotic arm.\nProhibit manual intervention of the robot arm during operation.";
                textContext1.gameObject.SetActive(true); // 显示正文文本1
            }

            // 显示正文文本2
            if (textContext2 != null)
            {
                textContext2.text = "3. Emergency response\nFamiliarise yourself with the location of the emergency stop button.\nIn the event of an accident, stop the machine and deal with it immediately.";
                textContext2.gameObject.SetActive(true); // 显示正文文本2
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

            // 隐藏正文文本1
            if (textContext1 != null)
            {
                textContext1.gameObject.SetActive(false); // 隐藏正文文本1
            }

            // 隐藏正文文本2
            if (textContext2 != null)
            {
                textContext2.gameObject.SetActive(false); // 隐藏正文文本2
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
