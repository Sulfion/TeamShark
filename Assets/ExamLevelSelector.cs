using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExamLevelSelector : MonoBehaviour
{
    public int level; 

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Examination");
    }
}
