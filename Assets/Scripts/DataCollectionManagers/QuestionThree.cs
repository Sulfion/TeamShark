using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stores answer for question three and sends to DataCollectedManager
public class QuestionThree : MonoBehaviour
{
    public int questionThreeAnswer;
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            questionThreeAnswer = 0;
        }
        if (val == 1)
        {
            questionThreeAnswer = 1;
        }
        if (val == 2)
        {
            questionThreeAnswer = 2;
        }
        if (val == 3)
        {
            questionThreeAnswer = 3;
        }
        if (val == 4)
        {
            questionThreeAnswer = 4;
        }
        if (val == 5)
        {
            questionThreeAnswer = 5;
        }
    }
}
