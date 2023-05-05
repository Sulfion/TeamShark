using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectTrackerFlash : MonoBehaviour
{
    public Flashcards FlashcardsScript;

    public GameObject GuideButton;

    [Header("Correct Audio")]
    public GameObject NPCAudioCorrect2;
    public GameObject NPCAudioCorrect4;
    public GameObject NPCAudioCorrect6;
    public GameObject NPCAudioCorrect8;

    
    private bool HasAudio2 = false;
    
    private bool HasAudio4 = false;
    
    private bool HasAudio6 = false;
    
    private bool HasAudio8 = false;

    
    void Update()
    {
        if (FlashcardsScript.CorrectGuesses == 2)
        {
            if (HasAudio2 == false)
            {
                NPCAudioCorrect2.SetActive(true);
                HasAudio2 = true;
            }

        }

        if (FlashcardsScript.CorrectGuesses == 4)
        {
            if (HasAudio4 == false)
            {
                NPCAudioCorrect2.SetActive(false);
                NPCAudioCorrect4.SetActive(true);
                HasAudio4 = true;
            }
        }

        if (FlashcardsScript.CorrectGuesses == 6)
        {
            if (HasAudio6 == false)
            {
                NPCAudioCorrect4.SetActive(false);
                NPCAudioCorrect6.SetActive(true);
                HasAudio6 = true;
            }

        }

        if (FlashcardsScript.CorrectGuesses == 8)
        {
            if (HasAudio8 == false)
            {
                NPCAudioCorrect6.SetActive(false);
                NPCAudioCorrect8.SetActive(true);
                HasAudio8 = true;
                GuideButton.SetActive(false);
            }

        }
    }
}
