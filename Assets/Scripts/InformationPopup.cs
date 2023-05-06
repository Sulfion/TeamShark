using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//this script will check when a users hand gets near an egg, and play an audio explanation
public class InformationPopup : MonoBehaviour
{
    public AudioSource hintAudioSource;  //this is to stop the audio from overlapping with hints

    private bool stopAudioBool = false;

    public AudioSource EggInfoAudioSource;

    public AudioClip BlondeRayInformation;
    public AudioClip CuckooRayInformation;
    public AudioClip NursehoundInformation;
    public AudioClip SmallEyedRayInformation;
    public AudioClip SmallSpottedCatsharkInformation;
    public AudioClip SpottedRayInformation;
    public AudioClip ThornbackRayInformation;
    public AudioClip UndulateRayInformation;

    //check if an audio explanation is already playing, if it is not and
    //a user gets close enough to an egg, play the appropriate explanation once
    public void OnTriggerEnter(Collider other)
    {
        if (!hintAudioSource.isPlaying) //first check that other audio is not playing
        {
            if (other.gameObject.CompareTag("BlondeRayTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(BlondeRayInformation);
            }
            if (other.gameObject.CompareTag("CuckooRayTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(CuckooRayInformation);
            }
            if (other.gameObject.CompareTag("NursehoundTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(NursehoundInformation);
            }
            if (other.gameObject.CompareTag("SmallEyedRayTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(SmallEyedRayInformation);
            }
            if (other.gameObject.CompareTag("SmallSpottedCatsharkTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(SmallSpottedCatsharkInformation);
            }
            if (other.gameObject.CompareTag("SpottedRayTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(SpottedRayInformation);
            }
            if (other.gameObject.CompareTag("ThornbackRayTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(ThornbackRayInformation);
            }
            if (other.gameObject.CompareTag("UndulateRayTrigger") && EggInfoAudioSource.isPlaying == false)
            {
                stopAudioBool = true;
                EggInfoAudioSource.PlayOneShot(UndulateRayInformation);
            }
        }
    }
}
