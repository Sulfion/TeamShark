using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//this script will check when a users hand gets near an egg, and play an audio explanation
public class InformationPopup : MonoBehaviour
{
    private bool stopAudioBool = false;

    public AudioSource EggInfoAudioSource;

    public AudioClip EggOneInformation;
    //public AudioClip EggTwoInformation;
    //public AudioClip EggThreeInformation;
    //public AudioClip EggFourInformation;
    //public AudioClip EggFiveInformation;
    //public AudioClip EggSixInformation;
    //public AudioClip EggSevenInformation;
    //public AudioClip EggEightInformation;
    //public AudioClip EggNineInformation;
    //public AudioClip EggTenInformation;

    //check if an audio explanation is already playing, if it is not and
    //a user gets close enough to an egg, play the appropriate explanation once
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EggCollector") && EggInfoAudioSource.isPlaying == false)
        {
            stopAudioBool = true;
            EggInfoAudioSource.PlayOneShot(EggOneInformation);
        }
    }
}
