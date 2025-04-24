using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class FireOptionHandler : MonoBehaviour
{
    public GameObject canvasFireOption; // Canvas_fire_option
    public TextMeshProUGUI textTitle; // Text_tittle
    public TextMeshProUGUI textContext; // Text_context
    public Image safetyStepImage; // safety step Image
    public Image fireExtinguisherDescriptionImage; // Fire extinguisher description_Image
    public Image fireActionImage; // fire_action_Image

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ShowCanvasAfterDelay());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideCanvas();
        }
    }

    private IEnumerator ShowCanvasAfterDelay()
    {
        yield return new WaitForSeconds(1.2f); // 等待1.2秒
        ShowCanvas();
    }

    private void ShowCanvas()
    {
        if (canvasFireOption != null)
        {
            canvasFireOption.SetActive(true);
        }

        if (textTitle != null)
        {
            textTitle.gameObject.SetActive(true);
        }

        if (textContext != null)
        {
            textContext.gameObject.SetActive(true);
        }

        if (safetyStepImage != null)
        {
            safetyStepImage.gameObject.SetActive(true);
        }

        if (fireExtinguisherDescriptionImage != null)
        {
            fireExtinguisherDescriptionImage.gameObject.SetActive(true);
        }

        if (fireActionImage != null)
        {
            fireActionImage.gameObject.SetActive(true);
        }
    }

    private void HideCanvas()
    {
        if (canvasFireOption != null)
        {
            canvasFireOption.SetActive(false);
        }

        if (textTitle != null)
        {
            textTitle.gameObject.SetActive(false);
        }

        if (textContext != null)
        {
            textContext.gameObject.SetActive(false);
        }

        if (safetyStepImage != null)
        {
            safetyStepImage.gameObject.SetActive(false);
        }

        if (fireExtinguisherDescriptionImage != null)
        {
            fireExtinguisherDescriptionImage.gameObject.SetActive(false);
        }

        if (fireActionImage != null)
        {
            fireActionImage.gameObject.SetActive(false);
        }
    }
}
