using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerUp : MonoBehaviour
{
    public EggLoader EggLoaderScript;

    public TMP_Text timerText;
    public float secondsCount;
    private int minuteCount;
    
    void Update()
    {
        UpdateTimerUI();
        TrackSceneEndingSavePlayerPref();
    }
    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = "Time: " + minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }

    public void TrackSceneEndingSavePlayerPref()
    {
        if (EggLoaderScript.CorrectGuesses1 == 8)
        {
            PlayerPrefs.SetFloat("SceneOnePlayTime", secondsCount/60);
        }
    }
}
