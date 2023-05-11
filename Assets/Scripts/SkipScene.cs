using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//if player wants to skip this scene, log how many eggs they have found until now
//move to next scene
public class SkipScene : MonoBehaviour
{
    public EggCollector eggCollector;

    public Button submitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = submitButton.GetComponent<Button>();
        btn.onClick.AddListener(SkipSceneMethod);
    }

    private void SkipSceneMethod()
    {
        PlayerPrefs.SetInt("NumberOfEggsFound", eggCollector.totalEggsCollected);
        SceneManager.LoadScene("Examination");
    }
}
