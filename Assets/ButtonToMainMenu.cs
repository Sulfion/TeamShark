using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonToMainMenu : MonoBehaviour
{
    public Button SkipButton;
    void Start()
    {
        Button btn = SkipButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadMainMenu);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }
}
