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
        Debug.Log(questionOne.questionOneAnswer);
        Debug.Log(questionTwo.questionTwoAnswer);
        Debug.Log(questionThree.questionThreeAnswer);
    }
}
