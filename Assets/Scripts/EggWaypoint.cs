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
    private GameObject targetEgg;

    public TextMeshProUGUI distanceFromEggMeter;
    public Vector3 _offset;

    private float lastCollectedEggTimer;
    private int eggCollectedCheck; //compare old and new egg value to see if an egg was collected
    private float waypointWaitTimer = 5f;

    private Coroutine enableWaypointRoutine;

    public GameObject markerObject;
    private bool markerBool = false;


    private void Start()
    {
        distanceFromEggMeter.enabled = false;

        eggCollectedCheck = eggCollector.totalEggsCollected;
    }

    void Update()
    {
        lastCollectedEggTimer += Time.deltaTime;
        Debug.Log(lastCollectedEggTimer);

        EnableWaypointAfterCertainTime();
        CheckIfEggCollected();
    }

    //if an egg has been collected, stop the waypoint and reset the timer
    private void CheckIfEggCollected()
    {
        if (eggCollectedCheck != eggCollector.totalEggsCollected)
        {
            StopCoroutine(enableWaypointRoutine);
            eggCollectedCheck = eggCollector.totalEggsCollected;
            distanceFromEggMeter.enabled = false;
            lastCollectedEggTimer = 0f;
        }
    }

    //enable the waypoint if an egg hasn't been collected for X seconds
    //disable it for X seconds when an egg is collected
    public void EnableWaypointAfterCertainTime()
    {
        if (lastCollectedEggTimer >= waypointWaitTimer)
        {
            targetEgg = GameObject.FindGameObjectWithTag("SharkEgg");
            targetEggTransform = GameObject.FindGameObjectWithTag("SharkEgg").transform;

            enableWaypointRoutine = StartCoroutine(StartWaypoint());
            distanceFromEggMeter.enabled = true;
        }
    }
    IEnumerator StartWaypoint()
    {
        WayPointManager();
        yield return null;
    }

    public void WayPointManager()
    {
        if (markerBool == false)
        {
            Instantiate(markerObject, targetEggTransform.position + _offset, Quaternion.identity);
            markerBool = true;
        }


        ////limit the icon to stay inside the screen boundaries
        //float minX = waypointImg.GetPixelAdjustedRect().width / 2;
        //float maxX = Screen.width - minX;
        //float minY = waypointImg.GetPixelAdjustedRect().height / 2;
        //float maxY = Screen.height - minY;

        ////set waypoint image to chosen egg
        //Vector2 pos = Camera.main.WorldToViewportPoint(targetEggTransform.position + _offset);

        //if (Vector3.Dot((targetEggTransform.position - transform.position), transform.forward) < 0)
        //{
        //    //Target is behind the player
        //    if (pos.x < Screen.width / 2) //if target is left, place to right side of screen
        //    {
        //        pos.x = maxX;
        //    }
        //    else //if target is right, place to left side of screen
        //    {
        //        pos.x = minX;
        //    }
        //}

        //pos.x = Mathf.Clamp(pos.x, minX, maxX);
        //pos.y = Mathf.Clamp(pos.y, minY, maxY);

        //waypointImg.transform.position = pos;
        //distanceFromEggMeter.text = ((int)Vector3.Distance(targetEggTransform.position, transform.position)).ToString() + "m";
    }
}
