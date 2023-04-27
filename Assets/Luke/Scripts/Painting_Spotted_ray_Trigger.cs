using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting_Spotted_ray_Trigger : MonoBehaviour
{
    public GameObject CorrectPanel;
    public GameObject IncorrectPanel;

    public EggLoader EggLoaderScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EggLoaderScript.IncorrectGuesses1 = EggLoaderScript.IncorrectGuesses1 + 1;
        IncorrectPanel.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EggLoaderScript.IncorrectGuesses1 = EggLoaderScript.IncorrectGuesses1 + 1;
            IncorrectPanel.SetActive(true);
        }
    }
}
