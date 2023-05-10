using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class HideEggUI : MonoBehaviour
{

    private string[] allEggTags = { "BlondeRayEgg", "CuckooRayEgg", "NursehoundEgg", "SmallEyedRayEgg",
                                    "SmallspottedCatsharkEgg", "SpottedRayEgg", "ThornbackRayEgg", "UndulateRayEgg"};

    private Coroutine cacheHideEggUIRoutine;

    public GameObject hintPanel;

    public void OnTriggerEnter(Collider other)
    {
        if (allEggTags.Contains(other.gameObject.tag))
        {
            cacheHideEggUIRoutine = StartCoroutine(HideEggRoutine());
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (cacheHideEggUIRoutine != null)
        {
            StopCoroutine(cacheHideEggUIRoutine);
        }
    }

    private IEnumerator HideEggRoutine()
    {
        yield return new WaitForSeconds(5);
        hintPanel = GameObject.FindGameObjectWithTag("HintPanel");
        hintPanel.SetActive(false);
    }
}
