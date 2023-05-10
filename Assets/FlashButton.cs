using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlashButton : MonoBehaviour
{
    public Button FlashcardButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = FlashcardButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadFlash);
    }

    public void LoadFlash()
    {
        SceneManager.LoadScene("Flashcards");
    }
}
