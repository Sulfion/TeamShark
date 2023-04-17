using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        MainMenu,
        AndrewScene
    }

    public void LoadScene (Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.AndrewScene.ToString());
    }
}
