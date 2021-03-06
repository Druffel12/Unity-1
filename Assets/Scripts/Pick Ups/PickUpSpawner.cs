﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour {

    public GameObject pickUp;
    public float range;
    public float spawnInterval;
    float spawnTimer;

	// Use this for initialization
	void Start ()
    {
        spawnTimer = 0;
	}
	
    void spawnPickup()
    {
        GameObject spawnedPickUp = Instantiate(pickUp);
        float randomX = Random.Range(-range,range);
        float randomZ = Random.Range(-range, range); 
        spawnedPickUp.transform.position = transform.position + new Vector3(randomX, 0, randomZ);
        spawnedPickUp.GetComponent<PickUp>().scoreAdded = Random.Range(1, 1);
    }
	// Update is called once per frame
	void Update ()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            spawnPickup();
            spawnTimer = spawnInterval;
        }
	}
}
