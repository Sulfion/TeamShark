using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button QuitButton;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = QuitButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadQuit);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadQuit()
    {
        Application.Quit();
    }
}
