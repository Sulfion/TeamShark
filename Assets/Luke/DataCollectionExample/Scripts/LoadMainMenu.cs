using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainMenu : MonoBehaviour
{
    public Button mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = mainMenuButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadMenu);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    
}
