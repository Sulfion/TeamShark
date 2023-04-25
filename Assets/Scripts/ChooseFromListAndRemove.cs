using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseFromListAndRemove : MonoBehaviour
{
    public List<GameObject> dummyList = new List<GameObject>();

    private GameObject chosenDummy;

    // Start is called before the first frame update
    void Start()
    {
        ChooseRandomFromListDeleteOnceChosen();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(chosenDummy);
    }
 
    private void ChooseRandomFromListDeleteOnceChosen()
    {
        if (dummyList.Count > 0)
        {
            chosenDummy = dummyList[Random.Range(0, dummyList.Count)];
            dummyList.Remove(chosenDummy);
        }
    }
}
