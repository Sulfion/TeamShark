using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{
    public Button startButton;

    public GameObject startPanel;
    public GameObject welcomePanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(Loadwelcome);
    }

    void Loadwelcome()
    {
        welcomePanel.SetActive(true);
        startPanel.SetActive(false);
    }
}
