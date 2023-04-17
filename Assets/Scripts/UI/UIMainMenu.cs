using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startGame;
    [SerializeField] Button _exitGame;

    // Start is called before the first frame update
    void Start()
    {
        _startGame.onClick.AddListener(StartNewGame);
        _exitGame.onClick.AddListener(ExitGame);
    }

    private void StartNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
