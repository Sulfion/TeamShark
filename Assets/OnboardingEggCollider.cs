using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingEggCollider : MonoBehaviour
{
    public GameObject ThisGameObject;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject ThisPanel;
    public GameObject ThatPanel;
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "SharkEgg")
        {
            cube1.SetActive(true);
            cube2.SetActive(true);
            ThatPanel.SetActive(true);
            ThisPanel.SetActive(false);
            ThisGameObject.SetActive(false);
        }
    }
}
