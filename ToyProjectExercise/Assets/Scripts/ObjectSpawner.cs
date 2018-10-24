using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    [SerializeField]
    GameObject[] fallingObjects;
    [SerializeField]
    float minRange = 10, maxRange = 10, spawnRate = 25;

    int fallingArrayMax;
	// Use this for initialization
	void Start () {
        int fallingArrayMax = fallingObjects.Length;
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}
}
