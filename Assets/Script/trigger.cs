using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class trigger : MonoBehaviour
{
    public CanvasGroup hintCanvasGroup;
    public TMP_Text hintText;
    public string hintMessage;
    private bool hasEntered = false;

    [System.Obsolete]
    void OnTriggerEnter(Collider other)
    {
        if (!hasEntered)
        {
            hasEntered = true;
            hintText.text = hintMessage;
            StartCoroutine(FadeInOutHint());
        }

    }

    IEnumerator FadeInOutHint()
    {
        float duration = 2f; // 渐隐渐现的总时间
        float fadeInTime = 0.5f; // 渐现的时间
        float fadeOutTime = 0.5f; // 渐隐的时间
        float elapsedTime = 0f;

        hintCanvasGroup.alpha = 0f; // 初始时设置为完全透明

        // 渐现
        while (elapsedTime < fadeInTime)
        {
            elapsedTime += Time.deltaTime;
            hintCanvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeInTime);
            yield return null;
        }

        // 停留
        yield return new WaitForSeconds(duration - fadeInTime - fadeOutTime);

        // 渐隐
        elapsedTime = 0f;
        while (elapsedTime < fadeOutTime)
        {
            elapsedTime += Time.deltaTime;
            hintCanvasGroup.alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutTime);
            yield return null;
        }
    }
}
