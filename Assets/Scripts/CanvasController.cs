using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 用于场景管理

public class CanvasController : MonoBehaviour
{
    public Canvas canvasTip;
    public Canvas canvasFunction;
    public Canvas canvasSecurityKnowledge;
    public Canvas canvasOnlineTest;

    void Start()
    {
        // 在开始时隐藏除Canvas TIP外的所有画布
        foreach (Canvas c in FindObjectsOfType<Canvas>())
        {
            if (c != canvasTip)
            {
                c.gameObject.SetActive(false);
            }
        }

        // 确保Canvas TIP是可见的
        canvasTip.gameObject.SetActive(true);

        // 调试信息
        Debug.Log("Canvas Tip Active: " + canvasTip.gameObject.activeInHierarchy);
    }

    public void OnStartButtonClick()
    {
        // 切换到Canvas function
        SwitchToCanvas(canvasFunction);
    }

    public void OnSecurityKnowledgeButtonClick()
    {
        // 切换到Canvas security knowledge
        SwitchToCanvas(canvasSecurityKnowledge);
    }

    public void OnSafetyExperienceButtonClick()
    {
        // 加载新的场景 FactorySceneSafetytraining
        SceneManager.LoadScene("FactorySceneSafetytraining");
    }

    public void OnOnlineAssessmentButtonClick()
    {
        // 切换到Canvas online test
        SwitchToCanvas(canvasOnlineTest);
    }

    public void OnLogoutButtonClick()
    {
        // 返回到Canvas TIP
        SwitchToCanvas(canvasTip);
    }

    private void SwitchToCanvas(Canvas targetCanvas)
    {
        // 隐藏所有画布
        foreach (Canvas c in FindObjectsOfType<Canvas>())
        {
            c.gameObject.SetActive(false);
        }

        // 显示目标画布
        targetCanvas.gameObject.SetActive(true);

        // 调试信息
        Debug.Log(targetCanvas.name + " Active: " + targetCanvas.gameObject.activeInHierarchy);
    }
}