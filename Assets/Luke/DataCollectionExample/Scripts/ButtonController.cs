using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;


    public GameObject button1first;
    public GameObject button1second;

    public GameObject button2first;
    public GameObject button2second;

    public GameObject button3first;
    public GameObject button3second;

    public GameObject button4first;
    public GameObject button4second;

    public GameObject button5first;
    public GameObject button5second;

    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
        button4.onClick.AddListener(() => buttonCallBack(button4));
        button5.onClick.AddListener(() => buttonCallBack(button5));
    }
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            //Your code for button 1
            Debug.Log("Clicked: Frustration " + button1.name);
            buttonTwo(); buttonThree(); buttonFour(); buttonFive();
        }

        if (buttonPressed == button2)
        {
            //Your code for button 2
            Debug.Log("Clicked: Frustration " + button2.name);
            buttonOne(); buttonThree(); buttonFour(); buttonFive();
        }

        if (buttonPressed == button3)
        {
            //Your code for button 3
            Debug.Log("Clicked: Frustration " + button3.name);
            buttonOne(); buttonTwo(); buttonFour(); buttonFive();
        }


        if (buttonPressed == button4)
        {
            //Your code for button 4
            Debug.Log("Clicked: Frustration " + button4.name);
            buttonOne(); buttonTwo(); buttonThree(); buttonFive();
        }

        if (buttonPressed == button5)
        {
            //Your code for button 5
            Debug.Log("Clicked: Frustration " + button5.name);
            buttonOne(); buttonTwo(); buttonThree(); buttonFour();
        }

    }
    
    void buttonOne()
    {
        button1second.SetActive(true);
        button1first.SetActive(false);
    }

    void buttonTwo()
    {
        button2second.SetActive(true);
        button2first.SetActive(false);
    }
    void buttonThree()
    {
        button3second.SetActive(true);
        button3first.SetActive(false);
    }

    void buttonFour()
    {
        button4second.SetActive(true);
        button4first.SetActive(false);
    }
    void buttonFive()
    {
        button5second.SetActive(true);
        button5first.SetActive(false);
    }
}
