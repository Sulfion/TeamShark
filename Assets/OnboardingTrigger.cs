using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingTrigger : MonoBehaviour
{
    public GameObject ThisGameObject;
    public GameObject ThatGameObject;
    public GameObject ThisPanel;
    public GameObject ThatPanel;
    void OnTriggerEnter(Collider target)
        {
            if (target.tag == "Player")
            {
                ThatGameObject.SetActive(true);
                ThatPanel.SetActive(true);
                ThisPanel.SetActive(false);
                ThisGameObject.SetActive(false);
            }
        }
}
