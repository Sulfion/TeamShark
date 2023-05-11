using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClassroomButton : MonoBehaviour
{
    public Button RoomButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = RoomButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadClassroom);
    }

    public void LoadClassroom()
    {
        SceneManager.LoadScene("LukeScene");
    }
}
