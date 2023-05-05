using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointHide : MonoBehaviour
{
    public GameObject ThisObject;
    public GameObject ExplainationPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ExplainationPanel.SetActive(false);
            ThisObject.SetActive(false);

        }
    }
}
