using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Flashcards : MonoBehaviour
{
    public int CorrectGuesses;
    public TMP_Text CorrectGuessesText;

    public int IncorrectGuesses;
    public TMP_Text IncorrectGuessesText;

    //public GameObject ThisScript;

    [Header("UI Buttons")]
    public GameObject ContinueButton;
    public GameObject RestartButton;

    [Header("Eggs")]
    public GameObject SpottedRayEgg;
    public GameObject ThornbackRayEgg;
    public GameObject SmallEyedRayEgg;
    public GameObject UndulateRayEgg;
    public GameObject CuckooRayEgg;
    public GameObject BlondeRayEgg;
    public GameObject StarrySkateEgg;
    public GameObject BlueSkakeEgg;
    public GameObject FlapperSkakeEgg;
    public GameObject WhiteSkakeEgg;
    public GameObject SmallspottedCatsharkEgg;
    public GameObject NursehoundEgg;
    public GameObject BlackmouthCatsharkEgg;

    [Header("Correct panel")]
    public GameObject CorrectSpottedRay;
    public GameObject CorrectThornbackRay;
    public GameObject CorrectSmallEyedRay;
    public GameObject CorrectUndulateRay;
    public GameObject CorrectCuckooRay;
    public GameObject CorrectBlondeRay;
    public GameObject CorrectStarrySkate;
    public GameObject CorrectBlueSkake;
    public GameObject CorrectFlapperSkake;
    public GameObject CorrectWhiteSkake;
    public GameObject CorrectSmallspottedCatshark;
    public GameObject CorrectNursehound;
    public GameObject CorrectBlackmouthCatshark;

    [Header("Incorrect panel")]
    public GameObject IncorrectSpottedRay;
    public GameObject IncorrectThornbackRay;
    public GameObject IncorrectSmallEyedRay;
    public GameObject IncorrectUndulateRay;
    public GameObject IncorrectCuckooRay;
    public GameObject IncorrectBlondeRay;
    public GameObject IncorrectStarrySkate;
    public GameObject IncorrectBlueSkake;
    public GameObject IncorrectFlapperSkake;
    public GameObject IncorrectWhiteSkake;
    public GameObject IncorrectSmallspottedCatshark;
    public GameObject IncorrectNursehound;
    public GameObject IncorrectBlackmouthCatshark;

    [Header("Key ID Panel")]
    public GameObject ScoreBoard;
    public GameObject TV1;
    public GameObject TV2;
    public GameObject TV3;
    public GameObject TV4;
    public GameObject TV5;
    public GameObject TV6;
    public GameObject TV7;

    [Header("Buttons")]
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;
    public Button button13;

    public List<GameObject> EggList = new List<GameObject>();

    private GameObject chosenEgg;
    

    // Start is called before the first frame update
    void Start()
    {
        allfalse();
        CorrectGuesses = 0;
        IncorrectGuesses = 0;
        ChooseRandomFromListDeleteOnceChosen();

    }

    // Update is called once per frame
    void Update()
    {
        CorrectGuessesText.text = "Correct Guesses: " + CorrectGuesses.ToString() + "/8";
        IncorrectGuessesText.text = "Incorrect Guesses: " + IncorrectGuesses.ToString();
        if (CorrectGuesses == 8)
        {
            FinishFlash();
        }
    }

    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
        button4.onClick.AddListener(() => buttonCallBack(button4));
        button5.onClick.AddListener(() => buttonCallBack(button5));
        button6.onClick.AddListener(() => buttonCallBack(button6));
        button7.onClick.AddListener(() => buttonCallBack(button7));
        button8.onClick.AddListener(() => buttonCallBack(button8));
        button9.onClick.AddListener(() => buttonCallBack(button9));
        button10.onClick.AddListener(() => buttonCallBack(button10));
        button11.onClick.AddListener(() => buttonCallBack(button11));
        button12.onClick.AddListener(() => buttonCallBack(button12));
        button13.onClick.AddListener(() => buttonCallBack(button13));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            //code for button 1
            Debug.Log("Clicked: " + button1.name);

            if (SpottedRayEgg.activeInHierarchy == false)
            {
                IncorrectSpottedRay.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (SpottedRayEgg.activeInHierarchy == true)
            {
                CorrectSpottedRay.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }

        }

        if (buttonPressed == button2)
        {
            //code for button 2
            Debug.Log("Clicked: " + button2.name);

            if (ThornbackRayEgg.activeInHierarchy == false)
            {
                IncorrectThornbackRay.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (ThornbackRayEgg.activeInHierarchy == true)
            {
                CorrectThornbackRay.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }

        if (buttonPressed == button3)
        {
            //code for button 3
            Debug.Log("Clicked: " + button3.name);

            if (SmallEyedRayEgg.activeInHierarchy == false)
            {
                IncorrectSmallEyedRay.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (SmallEyedRayEgg.activeInHierarchy == true)
            {
                CorrectSmallEyedRay.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }

        }

        if (buttonPressed == button4)
        {
            //code for button 4
            Debug.Log("Clicked: " + button4.name);

            if (UndulateRayEgg.activeInHierarchy == false)
            {
                IncorrectUndulateRay.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (UndulateRayEgg.activeInHierarchy == true)
            {
                CorrectUndulateRay.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }

        if (buttonPressed == button5)
        {
            //code for button 5
            Debug.Log("Clicked: " + button5.name);

            if (CuckooRayEgg.activeInHierarchy == false)
            {
                IncorrectCuckooRay.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }        
            
            if (CuckooRayEgg.activeInHierarchy == true)
            {
                CorrectCuckooRay.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }

        }

        if (buttonPressed == button6)
        {
            //code for button 6
            Debug.Log("Clicked: " + button6.name);

            if (BlondeRayEgg.activeInHierarchy == false)
            {
                IncorrectBlondeRay.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (BlondeRayEgg.activeInHierarchy == true)
            {
                CorrectBlondeRay.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }

        if (buttonPressed == button7)
        {
            //code for button 7
            Debug.Log("Clicked: " + button7.name);

            if (StarrySkateEgg.activeInHierarchy == false)
            {
                IncorrectStarrySkate.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (StarrySkateEgg.activeInHierarchy == true)
            {
                CorrectStarrySkate.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }

        if (buttonPressed == button8)
        {
            //code for button 8
            Debug.Log("Clicked: " + button8.name);

            if (BlueSkakeEgg.activeInHierarchy == false)
            {
                IncorrectBlueSkake.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
                
            }

            if (BlueSkakeEgg.activeInHierarchy == true)
            {
                CorrectBlueSkake.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }

        if (buttonPressed == button9)
        {
            //code for button 9
            Debug.Log("Clicked: " + button9.name);

            if (FlapperSkakeEgg.activeInHierarchy == false)
            {
                IncorrectFlapperSkake.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
            }

            if (FlapperSkakeEgg.activeInHierarchy == true)
            {
                CorrectFlapperSkake.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }

        }

        if (buttonPressed == button10)
        {
            //code for button 10
            Debug.Log("Clicked: " + button10.name);

            if (WhiteSkakeEgg.activeInHierarchy == false)
            {
                IncorrectWhiteSkake.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
            }

            if (WhiteSkakeEgg.activeInHierarchy == true)
            {
                CorrectWhiteSkake.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }

        }

        if (buttonPressed == button11)
        {
            //code for button 11
            Debug.Log("Clicked: " + button11.name);

            if (SmallspottedCatsharkEgg.activeInHierarchy == false)
            {
                IncorrectSmallspottedCatshark.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
            }

            if (SmallspottedCatsharkEgg.activeInHierarchy == true)
            {
                CorrectSmallspottedCatshark.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }

        if (buttonPressed == button12)
        {
            //code for button 12
            Debug.Log("Clicked: " + button12.name);

            if (NursehoundEgg.activeInHierarchy == false)
            {
                IncorrectNursehound.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
            }

            if (NursehoundEgg.activeInHierarchy == true)
            {
                CorrectNursehound.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }

        }

        if (buttonPressed == button13)
        {
            //code for button 13
            Debug.Log("Clicked: " + button13.name);

            if (BlackmouthCatsharkEgg.activeInHierarchy == false)
            {
                IncorrectBlackmouthCatshark.SetActive(true);
                IncorrectGuesses = IncorrectGuesses + 1;
            }

            if (BlackmouthCatsharkEgg.activeInHierarchy == true)
            {
                CorrectBlackmouthCatshark.SetActive(true);
                CorrectGuesses = CorrectGuesses + 1;
                allIncorrectFalse();
                allfalse();
                ChooseRandomFromListDeleteOnceChosen();
            }
        }
    }
    
    void allfalse()
    {
        SpottedRayEgg.SetActive(false);
        ThornbackRayEgg.SetActive(false);
        SmallEyedRayEgg.SetActive(false);
        UndulateRayEgg.SetActive(false);
        CuckooRayEgg.SetActive(false);
        BlondeRayEgg.SetActive(false);
        StarrySkateEgg.SetActive(false);
        BlueSkakeEgg.SetActive(false);
        FlapperSkakeEgg.SetActive(false);
        WhiteSkakeEgg.SetActive(false);
        SmallspottedCatsharkEgg.SetActive(false);
        NursehoundEgg.SetActive(false);
        BlackmouthCatsharkEgg.SetActive(false);
        
        ScoreBoard.SetActive(true);
        TV1.SetActive(false);
        TV2.SetActive(false);
        TV3.SetActive(false);
        TV4.SetActive(false);
        TV5.SetActive(false);
        TV6.SetActive(false);
        TV7.SetActive(false);

    }

    void allIncorrectFalse()
    {
        IncorrectSpottedRay.SetActive(false);
        IncorrectThornbackRay.SetActive(false);
        IncorrectSmallEyedRay.SetActive(false);
        IncorrectUndulateRay.SetActive(false);
        IncorrectCuckooRay.SetActive(false);
        IncorrectBlondeRay.SetActive(false);
        IncorrectStarrySkate.SetActive(false);
        IncorrectBlueSkake.SetActive(false);
        IncorrectFlapperSkake.SetActive(false);
        IncorrectWhiteSkake.SetActive(false);
        IncorrectSmallspottedCatshark.SetActive(false);
        IncorrectNursehound.SetActive(false);
        IncorrectBlackmouthCatshark.SetActive(false);
    }

    private void ChooseRandomFromListDeleteOnceChosen()
    {
        if (EggList.Count > 0)
        {
            chosenEgg = EggList[Random.Range(0, EggList.Count)];
            chosenEgg.SetActive(true);
            EggList.Remove(chosenEgg);
        }
    }

    void FinishFlash()
    {
        ContinueButton.SetActive(true);
        RestartButton.SetActive(true);
        //ThisScript.SetActive(false);
    }
}
