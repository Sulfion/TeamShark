using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamCorrectAnswerTracker : MonoBehaviour
{
    [Header("TV panels")]
    public GameObject StartPanel;
    public GameObject TV1;
    public GameObject TV2;
    public GameObject TV3;
    public GameObject TV4;
    public GameObject TV5;
    public GameObject TV6;
    public GameObject TV7;

    [Header("Buttons")]
    public GameObject HelpButton;
    public GameObject FinishedButton;

    [Header("Scripts")]
    public ExamEggLoader EggLoaderScript;
    public GameObject ThisObject;

    public GameObject AudioExamEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EggLoaderScript.CorrectGuesses2 == 8)
        {
            AudioExamEnd.SetActive(true);
            ThisObject.GetComponent<TimerUp>().enabled = false;

            PlayerPrefs.SetInt("ExamCorrectGuesses", EggLoaderScript.CorrectGuesses2);
            PlayerPrefs.SetInt("ExamIncorrectGuesses", EggLoaderScript.IncorrectGuesses2);

            StartPanel.SetActive(true);
            TV1.SetActive(false);
            TV2.SetActive(false);
            TV3.SetActive(false);
            TV4.SetActive(false);
            TV6.SetActive(false);
            TV7.SetActive(false);
            HelpButton.SetActive(false);
            FinishedButton.SetActive(true);
        }
    }
}
