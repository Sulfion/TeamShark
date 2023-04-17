using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOutOfBoundsEggs : MonoBehaviour
{
    private float bottomLimit = -10.0f;
    private Vector3 returnPosition = new Vector3(0, 3, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ReturnEggs();
    }

    public void ReturnEggs()
    {
        if (this.gameObject.transform.position.y < bottomLimit)
        {
            this.gameObject.transform.position = returnPosition;
        }
    }
}
