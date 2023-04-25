using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//this script will create a waypoint to a random undiscovered egg after a certain amount of time has elapsed
//if an egg is collected, the waypoint will dissappear again and then reappear after enough time has passed again
public class EggWaypoint : MonoBehaviour
{
    public EggCollector eggCollector;

    private Transform targetEggTransform;
    public GameObject targetEgg;

    public Vector3 _offset;

    private float lastCollectedEggTimer;
    private int eggCollectedCheck; //compare old and new egg value to see if an egg was collected
    private float waypointWaitTimer = 5f;
    private bool stopRunning = false;

    public GameObject markerObject;
    private GameObject markerObjectCopy;



    private void Start()
    {
        eggCollectedCheck = eggCollector.totalEggsCollected;
    }

    void Update()
    {
        CheckIfEggCollected();
        SetMarkerPosition();
    }

    //check if an egg has been collected recently or not
    private void CheckIfEggCollected()
    {
        //if they HAVE NOT collected an egg recently, start timer
        if (eggCollectedCheck == eggCollector.totalEggsCollected)
        {
            lastCollectedEggTimer += Time.deltaTime;

            if (lastCollectedEggTimer >= waypointWaitTimer && stopRunning == false) //find a spot to spawn the marker after specified time
            {
                targetEgg = GameObject.FindGameObjectWithTag("SharkEgg");
                targetEggTransform = GameObject.FindGameObjectWithTag("SharkEgg").transform;
                MarkerSpawner();
                stopRunning = true;
            }
        }

        //if they HAVE collected an egg recently reset timer, destroy old marker
        if (eggCollectedCheck != eggCollector.totalEggsCollected)
        {
            lastCollectedEggTimer = 0f;
            eggCollectedCheck = eggCollector.totalEggsCollected;
            Destroy(markerObjectCopy);
            stopRunning = false;
        }
    }

    public void MarkerSpawner()
    {
        markerObjectCopy = Instantiate(markerObject, targetEggTransform.position + _offset, Quaternion.identity);
    }

    //make the marker follow the egg
    private void SetMarkerPosition()
    {
        if (markerObjectCopy != null)
        {
            markerObjectCopy.transform.position = targetEggTransform.position + _offset;
        }
        else
        {
            return;
        }
    }
}
