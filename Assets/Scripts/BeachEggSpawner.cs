using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//this script will randomly spawn one of each object within the spawn limits
public class BeachEggSpawner : MonoBehaviour
{
    public GameObject[] allEggs;
    public GameObject circleCenterObject;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = new Vector3(0, 2, 0); //control height of egg spawns
        StartCoroutine(SpawnOneOfEachEggRoutine());
    }

    //start coroutine to spawn one of each shark egg from array at calculated random position
    IEnumerator SpawnOneOfEachEggRoutine()
    {
        foreach (GameObject egg in allEggs)
        {
            Vector3 newPos = RandomPointOnCircleEdge(Random.Range(24, 28));
            Instantiate(egg, newPos + _offset, Quaternion.identity);
        }
        yield return null;
    }

    //calculate random spawn position on x and z by using y=0
    //normalized so objects spawn on outer edge
    private Vector3 RandomPointOnCircleEdge(float radius)
    {
        var vector2 = Random.insideUnitCircle.normalized * radius;
        return new Vector3(vector2.x, 0, vector2.y);
    }
}

