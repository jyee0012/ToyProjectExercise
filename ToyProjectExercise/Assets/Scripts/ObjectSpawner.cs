using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    [SerializeField]
    GameObject[] fallingObjects;

    // blue sphere will represent center
    [SerializeField]
    float leftAnchor = 10, // yellow small sphere
        rightAnchor = 10, // red small sphere 
        spawnRate = 25, // spawn rate not used
        timeDelay = 5, // time between spawns
        destroyDelay = 30; // time it takes to destroy the spawned obj

    [SerializeField]
    ScoreAndTimer scoreTimer;
    [SerializeField]
    bool canSpawn = true;
    int fallingArrayMax, randIndex, randSpawn;
    float timeStamp = 0;

	// Use this for initialization
	void Start () {
        // get array length
        fallingArrayMax = fallingObjects.Length;
	}
	
	// Update is called once per frame
	void Update () {
        // set timer for spawning
        if (timeStamp < Time.time && canSpawn)
        {
            // each time spawn a random among the array
            randIndex = Random.Range(0, fallingArrayMax);  // random index for array element inside falling object array
            randSpawn = Random.Range(0, Mathf.RoundToInt(leftAnchor + rightAnchor)); // random spawn location between left & right anchor, starting from left to right
            //Debug.Log(randIndex + ":" + fallingArrayMax);
            
            // get and modify spawn position
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(randSpawn - Mathf.RoundToInt(leftAnchor), 0, 0);

            GameObject currentFallObj = Instantiate(fallingObjects[randIndex], spawnPos, fallingObjects[randIndex].transform.rotation);
            Destroy(currentFallObj, destroyDelay);

            // reset timer
            timeStamp = Time.time + timeDelay;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, 0.5f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position + new Vector3(-leftAnchor, 0), 0.2f);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + new Vector3(rightAnchor, 0), 0.2f);
    }
}
