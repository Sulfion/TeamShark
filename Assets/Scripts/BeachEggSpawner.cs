using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//this script will randomly spawn one of each object within the spawn limits
public class BeachEggSpawner : MonoBehaviour
{
    public GameObject[] allEggs;
    public GameObject circleCenterObject;
    public Vector2 circleCenter;
    public int spawnRadius = 30;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnOneOfEachEggRoutine());
        circleCenter = circleCenterObject.transform.position;
    }

    //start coroutine to spawn one of each shark egg from array at calculated random position
    IEnumerator SpawnOneOfEachEggRoutine()
    {
        foreach (GameObject egg in allEggs)
        {
            Vector3 newPos = RandomPointOnCircleEdge(spawnRadius);
            Instantiate(egg, newPos, Quaternion.identity);
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

