using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCColistion : MonoBehaviour
{
    public GameObject StartMenu;
    //public GameObject EggLoaderScript;
    public GameObject StartAudio;
    public GameObject Waypoint;
    public GameObject ExplainationPanel;
    private bool done=false;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (done == false)
            {
                StartMenu.SetActive(false);
                Waypoint.SetActive(false);
                ExplainationPanel.SetActive(true);
                StartAudio.SetActive(true);
                
                done = true;
            }
            
        }
    }
}
