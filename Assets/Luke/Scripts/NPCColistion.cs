using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCColistion : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject EggLoaderScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartMenu.SetActive(false);
            EggLoaderScript.SetActive(true);
        }
    }
}
