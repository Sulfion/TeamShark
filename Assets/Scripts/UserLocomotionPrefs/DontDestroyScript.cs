using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScript : MonoBehaviour
{
    // Keep the gameobject (player) from being destroyed in next scene
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
