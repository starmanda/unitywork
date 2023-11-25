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
        float duration = 2f; // �������ֵ���ʱ��
        float fadeInTime = 0.5f; // ���ֵ�ʱ��
        float fadeOutTime = 0.5f; // ������ʱ��
        float elapsedTime = 0f;

        hintCanvasGroup.alpha = 0f; // ��ʼʱ����Ϊ��ȫ͸��

        // ����
        while (elapsedTime < fadeInTime)
        {
            elapsedTime += Time.deltaTime;
            hintCanvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeInTime);
            yield return null;
        }

        // ͣ��
        yield return new WaitForSeconds(duration - fadeInTime - fadeOutTime);

        // ����
        elapsedTime = 0f;
        while (elapsedTime < fadeOutTime)
        {
            elapsedTime += Time.deltaTime;
            hintCanvasGroup.alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutTime);
            yield return null;
        }
    }
}
