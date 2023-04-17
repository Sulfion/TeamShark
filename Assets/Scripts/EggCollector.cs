using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attached to the players hands and will turn off eggs when they are touched and keep track of how many eggs have been collected
public class EggCollector : MonoBehaviour
{
    private int totalEggsCollected = 0;
    private bool allEggsCollected = false; //track when to change scenes

    public ParticleSystem collectedEffect;


    //disable egg when player touches it, add to counter and play collected particle effect
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SharkEgg"))
        {
            totalEggsCollected++;
            collectedEffect.Play();
            other.gameObject.SetActive(false);

            if (totalEggsCollected == 10)
            {
                allEggsCollected = true;
            }
        }
    }
}
