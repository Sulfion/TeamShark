using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this will clear all player prefs when a new session begins
public class WipeDataOnAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
