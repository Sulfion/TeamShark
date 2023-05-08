using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stores answer for question two and sends to DataCollectedManager
public class QuestionTwo : MonoBehaviour
{
    public int questionTwoAnswer;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            questionTwoAnswer = 0;
        }
        if (val == 1)
        {
            questionTwoAnswer = 1;
        }
        if (val == 2)
        {
            questionTwoAnswer = 2;
        }
        if (val == 3)
        {
            questionTwoAnswer = 3;
        }
        if (val == 4)
        {
            questionTwoAnswer = 4;
        }
        if (val == 5)
        {
            questionTwoAnswer = 5;
        }
    }
}
