using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueToAndrew : MonoBehaviour
{
    public Button ContinueButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = ContinueButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadAndrew);
    }

    public void LoadAndrew()
    {
        SceneManager.LoadScene("CaitlinScene");
    }
}
