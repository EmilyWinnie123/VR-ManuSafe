using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    // 引用不同Canvas的公共变量
    public Canvas canvasSecurityKnowledge; // "Canvas Security Knowledge" 画布
    public Canvas canvasFunction;          // "Canvas Function" 画布

    // 当点击“Home”按钮时调用此方法返回到Canvas Function
    public void ReturnToFunctionCanvas()
    {
        // 确保我们只激活一个Canvas
        if (canvasSecurityKnowledge != null)
        {
            canvasSecurityKnowledge.gameObject.SetActive(false); // 关闭当前画布
        }
        if (canvasFunction != null)
        {
            canvasFunction.gameObject.SetActive(true); // 打开目标画布
        }
    }

    // 如果需要添加其他Canvas之间的切换逻辑，可以在下面定义相应的方法。
}
