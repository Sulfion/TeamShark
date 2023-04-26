using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFadeUIAction : MonoBehaviour
{
    
    public void FadeCanvasGroup(CanvasGroup cg, float end, float lerpTime = 0.5f)
    {
        StartCoroutine(FadeCanvasGroupRoutine(cg,end, lerpTime));
    }

    
    private IEnumerator FadeCanvasGroupRoutine(CanvasGroup cg, float end, float lerpTime = 0.5f)
    {
        float elapsedTime = 0f;
        float start = cg.alpha;

        while (elapsedTime < lerpTime)
        {
            cg.alpha = Mathf.Lerp(start, end, elapsedTime / lerpTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        cg.alpha = end;

        cg.blocksRaycasts = end != 0;
    }

}
