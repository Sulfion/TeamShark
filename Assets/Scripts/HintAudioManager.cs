using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script will play a random hint every 30 seconds, beginning after 30 seconds
public class HintAudioManager : MonoBehaviour
{
    public AudioSource randomSource;
    public AudioClip[] audioHints;

    public AudioSource informationPopupAudiosource;

    // Start is called before the first frame update
    void Start()
    {
        randomSource = GetComponent<AudioSource>();
        CallAudio();
    }


    void CallAudio()
    {
        InvokeRepeating("RandomSoundness", 30, 30);
    }

    void RandomSoundness()
    {
        if (!informationPopupAudiosource.isPlaying)
        {
            randomSource.clip = audioHints[Random.Range(0, audioHints.Length)];
            randomSource.Play();
            CallAudio();
        }
    }
}
