using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject spawnObject1;
    public GameObject spawnObject2;
    public GameObject spawnObject3;
    public GameObject spawnObject4;


    public float maxTime = 10;
    public float minTime = 1;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    public float index;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

        index = Random.Range(0, 5);
        


    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = minTime;
        
        if (index == 1)
        {
            Instantiate(spawnObject1, transform.position, spawnObject1.transform.rotation);
        }

        if (index == 2)
        {
            Instantiate(spawnObject2, transform.position, spawnObject2.transform.rotation);
        }

        if (index == 3)
        {
            Instantiate(spawnObject3, transform.position, spawnObject3.transform.rotation);
        }

        if (index == 4)
        {
            Instantiate(spawnObject4, transform.position, spawnObject4.transform.rotation);
        }

    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    
}
