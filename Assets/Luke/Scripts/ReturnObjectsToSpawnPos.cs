using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObjectsToSpawnPos : MonoBehaviour
{
    private float bottomLimit = -0.6f;
    private Vector3 returnPosition;

    // Start is called before the first frame update
    void Start()
    {
        returnPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ReturnObjects();
    }

    public void ReturnObjects()
    {
        if (this.gameObject.transform.position.y < bottomLimit)
        {
            this.gameObject.transform.position = returnPosition;
        }
    }
}
