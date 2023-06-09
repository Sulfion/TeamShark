using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EggLoader : MonoBehaviour
{
    public List<GameObject> EggList = new List<GameObject>();

    private GameObject chosenEgg;

    public int CorrectGuesses1;
    public TMP_Text CorrectGuesses1Text;
    public int IncorrectGuesses1;
    public TMP_Text IncorrectGuesses1Text;

    [Header("DoneBools")]
    public bool DoneSpottedRay;
    public bool DoneThornbackRay;
    public bool DoneSmallEyedRay;
    public bool DoneUndulateRay;
    public bool DoneCuckooRay;
    public bool DoneBlondeRay;
    public bool DoneStarrySkate;
    public bool DoneBlueSkake;
    public bool DoneFlapperSkake;
    public bool DoneWhiteSkake;
    public bool DoneSmallspottedCatshark;
    public bool DoneNursehound;
    public bool DoneBlackmouthCatshark;

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

    [Header("TV panels")]
    public GameObject TV1;
    public GameObject TV2;
    public GameObject TV3;
    public GameObject TV4;
    public GameObject TV5;
    public GameObject TV6;
    public GameObject TV7;

    private void ChooseRandomFromListDeleteOnceChosen()
    {
        if (EggList.Count > 0)
        {
            chosenEgg = EggList[Random.Range(0, EggList.Count)];
            chosenEgg.SetActive(true);
            EggList.Remove(chosenEgg);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CorrectGuesses1 = 0;
        IncorrectGuesses1 = 0;
        ChooseRandomFromListDeleteOnceChosen();
        DoneSpottedRay = false;
        DoneThornbackRay = false;
        DoneSmallEyedRay = false;
        DoneUndulateRay = false;
        DoneCuckooRay = false;
        DoneBlondeRay = false;
        DoneStarrySkate = false;
        DoneBlueSkake = false;
        DoneFlapperSkake = false;
        DoneWhiteSkake = false;
        DoneSmallspottedCatshark = false;
        DoneNursehound = false;
        DoneBlackmouthCatshark = false;
    }

    // Update is called once per frame
    void Update()
    {
        CorrectGuesses1Text.text = "Correct Guesses: " + CorrectGuesses1.ToString() + "/8";
        IncorrectGuesses1Text.text = "Incorrect Guesses: " + IncorrectGuesses1.ToString();

        if (CorrectSpottedRay.activeInHierarchy == true)
        {

            if (DoneSpottedRay == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneSpottedRay = true;
            }
            
        }
        if (CorrectThornbackRay.activeInHierarchy == true)
        {
            if (DoneThornbackRay == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneThornbackRay = true;
            }
        }
        if (CorrectSmallEyedRay.activeInHierarchy == true)
        {
            if (DoneSmallEyedRay == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneSmallEyedRay = true;
            }
        }
        if (CorrectUndulateRay.activeInHierarchy == true)
        {
            if (DoneUndulateRay == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneUndulateRay = true;
            }
        }
        if (CorrectCuckooRay.activeInHierarchy == true)
        {
            if (DoneCuckooRay == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneCuckooRay = true;
            }
        }
        if (CorrectBlondeRay.activeInHierarchy == true)
        {
            if (DoneBlondeRay == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneBlondeRay = true;
            }
        }
        if (CorrectStarrySkate.activeInHierarchy == true)
        {
            if (DoneStarrySkate == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneStarrySkate = true;
            }
        }
        if (CorrectBlueSkake.activeInHierarchy == true)
        {
            if(DoneBlueSkake == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneBlueSkake = true;
            }
        }
        if (CorrectFlapperSkake.activeInHierarchy == true)
        {
            if (DoneFlapperSkake == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneFlapperSkake = true;
            }
        }
        if (CorrectWhiteSkake.activeInHierarchy == true)
        {
            if (DoneWhiteSkake == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneWhiteSkake = true;
            }
        }
        if (CorrectSmallspottedCatshark.activeInHierarchy == true)
        {
            if (DoneSmallspottedCatshark == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneSmallspottedCatshark = true;
            }
        }
        if (CorrectNursehound.activeInHierarchy == true)
        {
            if (DoneNursehound == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneNursehound = true;
            }
        }
        if (CorrectBlackmouthCatshark.activeInHierarchy == true)
        {
            if (DoneBlackmouthCatshark == false)
            {
                CorrectGuesses1 = CorrectGuesses1 + 1;
                resetpanel();
                ChooseRandomFromListDeleteOnceChosen();
                DoneBlackmouthCatshark = true;
            }
        }
    }
    void resetpanel()
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

            TV1.SetActive(true);
            TV2.SetActive(false);
            TV3.SetActive(false);
            TV4.SetActive(false);
            TV6.SetActive(false);
            TV7.SetActive(false);
    }
}
