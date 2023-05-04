using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAt : MonoBehaviour
{
    public Transform Camera;
   
    private void LateUpdate()
    {
        transform.LookAt(Camera);
    }
}
