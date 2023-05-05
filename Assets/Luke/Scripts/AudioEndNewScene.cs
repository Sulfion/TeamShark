using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioEndNewScene : MonoBehaviour
{
    AudioSource myAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Audio Finished");
        SceneManager.LoadScene("Flashcards");
    }
}
