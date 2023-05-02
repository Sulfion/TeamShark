using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEndNPCExam : MonoBehaviour
{
    AudioSource myAudio;
    public GameObject EggLoaderScript;
    public GameObject ThisObject;
    public GameObject Eggwaypoint;
    public GameObject panel;



    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Audio Finished");
        loadEggScript();

    }

    void loadEggScript()
    {
        panel.SetActive(false);
        EggLoaderScript.SetActive(true);
        Eggwaypoint.SetActive(true);
        ThisObject.SetActive(false);
    }
}
