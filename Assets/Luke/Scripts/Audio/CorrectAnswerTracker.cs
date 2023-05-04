using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerTracker : MonoBehaviour
{
    public EggLoader EggLoaderScript;

    [Header("Correct Audio")]
    public GameObject NPCAudioCorrect1;
    public GameObject NPCAudioCorrect2;
    public GameObject NPCAudioCorrect3;
    public GameObject NPCAudioCorrect4;
    public GameObject NPCAudioCorrect5;
    public GameObject NPCAudioCorrect6;
    public GameObject NPCAudioCorrect7;
    public GameObject NPCAudioCorrect8;

    private bool HasAudio1 = false;
    private bool HasAudio2 = false;
    private bool HasAudio3 = false;
    private bool HasAudio4 = false;
    private bool HasAudio5 = false;
    private bool HasAudio6 = false;
    private bool HasAudio7 = false;
    private bool HasAudio8 = false;

    // Update is called once per frame
    void Update()
    {
        if (EggLoaderScript.CorrectGuesses1 == 1)
        {
            if(HasAudio1 == false)
            {
                NPCAudioCorrect1.SetActive(true);
                HasAudio1 = true;
            }
                
        }
        if (EggLoaderScript.CorrectGuesses1 == 2)
        {
            if (HasAudio2 == false)
            {
                NPCAudioCorrect1.SetActive(false);
                NPCAudioCorrect2.SetActive(true);
                HasAudio2 = true;
            }
            
        }
        if (EggLoaderScript.CorrectGuesses1 == 3)
        {
            if (HasAudio3 == false)
            {
                NPCAudioCorrect2.SetActive(false);
                NPCAudioCorrect3.SetActive(true);
                HasAudio3 = true;
            }
        }
        if (EggLoaderScript.CorrectGuesses1 == 4)
        {
            if (HasAudio4 == false)
            {
                NPCAudioCorrect3.SetActive(false);
                NPCAudioCorrect4.SetActive(true);
                HasAudio4 = true;
            }
        }
        if (EggLoaderScript.CorrectGuesses1 == 5)
        {
            if (HasAudio5 == false)
            {
                NPCAudioCorrect4.SetActive(false);
                NPCAudioCorrect5.SetActive(true);
                HasAudio5 = true;
            }
        }
        if (EggLoaderScript.CorrectGuesses1 == 6)
        {
            if (HasAudio6 == false)
            {
                NPCAudioCorrect5.SetActive(false);
                NPCAudioCorrect6.SetActive(true);
                HasAudio6 = true;
            }
            
        }
        if (EggLoaderScript.CorrectGuesses1 == 7)
        {
            if (HasAudio7 == false)
            {
                NPCAudioCorrect6.SetActive(false);
                NPCAudioCorrect7.SetActive(true);
                HasAudio7 = true;
            }
            
        }
        if (EggLoaderScript.CorrectGuesses1 == 8)
        {
            if (HasAudio8 == false)
            {
                NPCAudioCorrect7.SetActive(false);
                NPCAudioCorrect8.SetActive(true);
                HasAudio8 = true;
            }
            
        }
    }
}
