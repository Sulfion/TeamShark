using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEndNPCFlash : MonoBehaviour
{
    AudioSource myAudio;
    public GameObject ThisGameOject;
    public GameObject StartingPanel;
    public GameObject StartingButton;


    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Audio Finished");
        StartingButton.SetActive(true);
        StartingPanel.SetActive(false);
        ThisGameOject.SetActive(false);


    }
}
