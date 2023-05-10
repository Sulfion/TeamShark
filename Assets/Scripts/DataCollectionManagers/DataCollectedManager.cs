using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//move all data here to centralize it
public class DataCollectedManager : MonoBehaviour
{
    public QuestionOne questionOne;
    public QuestionTwo questionTwo;
    public QuestionThree questionThree;

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("DataCollectionQ1", questionOne.questionOneAnswer);
        PlayerPrefs.SetInt("DataCollectionQ2", questionTwo.questionTwoAnswer);
        PlayerPrefs.SetInt("DataCollectionQ3", questionThree.questionThreeAnswer);
    }
}
