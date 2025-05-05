using UnityEngine;
using System.Collections;

public class FadeController : MonoBehaviour
{
    public CanvasGroup fadeCanvasGroup;
    public float fadeDuration = 3f;


    public void StartFade(GameObject CurrentSphere, GameObject TargetSphere)
    {
                StartCoroutine(FadeTransition(() =>
        {
            CurrentSphere.SetActive(false);
            TargetSphere.SetActive(true);
        }));
    }
    public IEnumerator FadeOut()
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Lerp(0f, 1f, t / fadeDuration);
            yield return null;
        }
        fadeCanvasGroup.alpha = 1f;
    }

    public IEnumerator FadeIn()
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Lerp(1f, 0f, t / fadeDuration);
            yield return null;
        }
        fadeCanvasGroup.alpha = 0f;
    }

    public IEnumerator FadeTransition(System.Action midAction)
    {
        yield return FadeOut();
        midAction?.Invoke();
        yield return new WaitForSeconds(2.5f);
        yield return FadeIn();
    }
}
