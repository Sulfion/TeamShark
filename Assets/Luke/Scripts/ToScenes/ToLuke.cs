using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToLuke : MonoBehaviour
{
    public Button NewButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = NewButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadLuke1);
    }

    public void LoadLuke1()
    {
        SceneManager.LoadScene("LukeScene");
    }
}
