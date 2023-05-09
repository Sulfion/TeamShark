using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToMainMenu : MonoBehaviour
{
    public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = RestartButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadMainMenu);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }
}
