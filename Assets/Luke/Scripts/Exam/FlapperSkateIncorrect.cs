using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapperSkateIncorrect : MonoBehaviour
{
    public GameObject CorrectPanel;
    public GameObject IncorrectPanel;

    public ExamEggLoader ExamEggLoaderScript;

    public bool SpottedRay;
    public bool ThornbackRay;
    public bool SmallEyedRay;
    public bool UndulateRay;
    public bool CuckooRay;
    public bool BlondeRay;
    public bool StarrySkate;
    public bool BlueSkake;
    public bool FlapperSkake;
    public bool WhiteSkake;
    public bool SmallspottedCatshark;
    public bool Nursehound;
    public bool BlackmouthCatshark;

    // Start is called before the first frame update
    void Start()
    {
        SpottedRay = false;
        ThornbackRay = false;
        SmallEyedRay = false;
        UndulateRay = false;
        CuckooRay = false;
        BlondeRay = false;
        StarrySkate = false;
        BlueSkake = false;
        FlapperSkake = false;
        WhiteSkake = false;
        SmallspottedCatshark = false;
        Nursehound = false;
        BlackmouthCatshark = false;
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "SpottedRayEgg")
        {
            if (SpottedRay == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                SpottedRay = true;
                IncorrectPanelBlock();
            }

        }
        if (other.tag == "ThornbackRayEgg")
        {
            if (ThornbackRay == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                ThornbackRay = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "SmallEyedRayEgg")
        {
            if (SmallEyedRay == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                SmallEyedRay = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "UndulateRayEgg")
        {
            if (UndulateRay == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                UndulateRay = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "CuckooRayEgg")
        {
            if (CuckooRay == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                CuckooRay = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "BlondeRayEgg")
        {
            if (BlondeRay == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                BlondeRay = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "StarrySkateEgg")
        {
            if (StarrySkate == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                StarrySkate = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "BlueSkakeEgg")
        {
            if (BlueSkake == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                BlueSkake = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "FlapperSkakeEgg")
        {
            CorrectPanel.SetActive(true);
            Reset();
        }
        if (other.tag == "WhiteSkakeEgg")
        {
            if (WhiteSkake == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                WhiteSkake = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "SmallspottedCatsharkEgg")
        {
            if (SmallspottedCatshark == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                SmallspottedCatshark = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "NursehoundEgg")
        {
            if (Nursehound == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                Nursehound = true;
                IncorrectPanelBlock();
            }
        }
        if (other.tag == "BlackmouthCatsharkEgg")
        {
            if (BlackmouthCatshark == false)
            {
                ExamEggLoaderScript.IncorrectGuesses2 = ExamEggLoaderScript.IncorrectGuesses2 + 1;
                BlackmouthCatshark = true;
                IncorrectPanelBlock();
            }
        }
    }
    private void Reset()
    {
        SpottedRay = false;
        ThornbackRay = false;
        SmallEyedRay = false;
        UndulateRay = false;
        CuckooRay = false;
        BlondeRay = false;
        StarrySkate = false;
        BlueSkake = false;
        FlapperSkake = false;
        WhiteSkake = false;
        SmallspottedCatshark = false;
        Nursehound = false;
        BlackmouthCatshark = false;
        IncorrectPanel.SetActive(false);
    }
    void IncorrectPanelBlock()
    {
        if (ExamEggLoaderScript.DoneFlapperSkake == false)
        {
            IncorrectPanel.SetActive(true);
        }
    }
}
