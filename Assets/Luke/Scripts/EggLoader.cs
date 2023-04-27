using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggLoader : MonoBehaviour
{
    public List<GameObject> EggList = new List<GameObject>();

    private GameObject chosenEgg;

    public int CorrectGuesses1;
    public int IncorrectGuesses1;


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
        ChooseRandomFromListDeleteOnceChosen();
    }

    // Update is called once per frame
    void Update()
    {
        if (CorrectSpottedRay.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectThornbackRay.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectSmallEyedRay.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectUndulateRay.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectCuckooRay.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectBlondeRay.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectStarrySkate.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectBlueSkake.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectFlapperSkake.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectWhiteSkake.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectSmallspottedCatshark.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectNursehound.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }
        if (CorrectBlackmouthCatshark.activeInHierarchy == true)
        {
            CorrectGuesses1 = CorrectGuesses1 + 1;
            ChooseRandomFromListDeleteOnceChosen();
        }

    }
}
