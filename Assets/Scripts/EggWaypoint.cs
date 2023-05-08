using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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
    private float waypointWaitTimer = 30f;
    private bool stopRunning = false;

    public GameObject markerObject;
    private GameObject markerObjectCopy;
    private string chosenTag;

    private string[] allEggTags = { "BlondeRayEgg", "CuckooRayEgg", "NursehoundEgg", "SmallEyedRayEgg",
                                    "SmallspottedCatsharkEgg", "SpottedRayEgg", "ThornbackRayEgg", "UndulateRayEgg"};


    private void Start()
    {
        eggCollectedCheck = eggCollector.totalEggsCollected;
    }

    void Update()
    {
        CheckIfEggCollected();
        //SetMarkerPosition();
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
                chosenTag = allEggTags[Random.Range(0, allEggTags.Length)]; //choose a random tag from list, find gameobject with tag

                targetEgg = GameObject.FindGameObjectWithTag(chosenTag);
                targetEggTransform = GameObject.FindGameObjectWithTag(chosenTag).transform;

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
        markerObjectCopy = Instantiate(markerObject, targetEggTransform.position + _offset, Quaternion.Euler(0f,0f,90f));
    }

    //make the marker follow the egg
    //for testing purposes ONLY, uses a lot of resources
    //private void SetMarkerPosition()
    //{
    //    if (markerObjectCopy != null)
    //    {
    //        markerObjectCopy.transform.position = targetEggTransform.position + _offset;
    //    }
    //    else
    //    {
    //        return;
    //    }
    //}
}
