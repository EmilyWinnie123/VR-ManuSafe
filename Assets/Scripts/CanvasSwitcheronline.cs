using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcheronline : MonoBehaviour
{
    // 引用不同Canvas的公共变量
    public Canvas canvasOnlineTest; // "Canvas Online Test" 画布
    public Canvas canvasFunction;   // "Canvas Function" 画布

    void Start()
    {
        // 确保开始时只有一个Canvas是激活状态
        if (canvasFunction != null)
        {
            canvasFunction.gameObject.SetActive(true); // 默认显示Canvas Function
        }
        if (canvasOnlineTest != null)
        {
            canvasOnlineTest.gameObject.SetActive(false); // 默认隐藏Canvas Online Test
        }
    }

    // 当点击“Home”按钮时调用此方法返回到Canvas Function
    public void ReturnToFunctionCanvas()
    {
        // 切换两个Canvas的可见性
        if (canvasOnlineTest != null)
        {
            canvasOnlineTest.gameObject.SetActive(false); // 关闭当前画布
        }
        if (canvasFunction != null)
        {
            canvasFunction.gameObject.SetActive(true); // 打开目标画布
        }
    }
}
