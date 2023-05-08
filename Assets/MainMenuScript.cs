using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Button StartButton;
    

    // Start is called before the first frame update
    void Start()
    {
        Button btn = StartButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadStart);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadStart()
    {
        SceneManager.LoadScene("LukeScene");
    }
}
