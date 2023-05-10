using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExamFinishButton : MonoBehaviour
{
    public TimerUp timerUp;
    public Button FinishedButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = FinishedButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadData);
    }

    public void LoadData()
    {
        PlayerPrefs.SetFloat("ExaminationDuration", timerUp.secondsCount / 60);
        SceneManager.LoadScene("DataCollection");
    }
}
