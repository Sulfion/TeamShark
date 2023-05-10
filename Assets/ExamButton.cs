using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExamButton : MonoBehaviour
{
    public Button ExamToButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = ExamToButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadExam);
    }

    public void LoadExam()
    {
        SceneManager.LoadScene("Examination");
    }
}
