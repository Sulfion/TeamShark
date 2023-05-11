using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingCubeCollider : MonoBehaviour
{
    public GameObject OldAudio;
    public GameObject AudioFinish;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject ThisPanel;
    public GameObject ThatPanel;
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Cube")
        {
            OldAudio.SetActive(false);
            ThatPanel.SetActive(true);
            ThisPanel.SetActive(false);
            AudioFinish.SetActive(true);
            cube2.SetActive(false);
            cube1.SetActive(false);
        }
    }
}
