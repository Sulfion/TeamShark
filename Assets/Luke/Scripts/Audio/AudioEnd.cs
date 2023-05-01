using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnd : MonoBehaviour
{
    AudioSource myAudio;
    public GameObject ThisObject;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Audio Finished");
        ThisObject.SetActive(false);
    }
}
