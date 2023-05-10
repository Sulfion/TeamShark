using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeachButton : MonoBehaviour
{
    public Button BeachToButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = BeachToButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadBeach);
    }

    public void LoadBeach()
    {
        SceneManager.LoadScene("AndrewScene");
    }
}
