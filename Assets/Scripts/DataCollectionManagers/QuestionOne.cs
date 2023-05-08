using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stores answer for question one and sends to DataCollectedManager
public class QuestionOne : MonoBehaviour
{
    public int questionOneAnswer;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            questionOneAnswer = 0;
        }
        if (val == 1)
        {
            questionOneAnswer = 1;
        }
        if (val == 2)
        {
            questionOneAnswer = 2;
        }
        if (val == 3)
        {
            questionOneAnswer = 3;
        }
        if (val == 4)
        {
            questionOneAnswer = 4;
        }
        if (val == 5)
        {
            questionOneAnswer = 5;
        }
    }
}
