using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//rotates a gameobject on chosen axis
public class Rotator : MonoBehaviour
{
    public float rotateSpeed;

    public Vector3 rotationDirection = new Vector3();

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed * rotationDirection * Time.deltaTime);
    }
}
