using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject spawnObject;

    public float maxTime = 10;
    public float minTime = 1;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

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

    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = minTime;
        Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    public void Update()
    {
        if (PlayerPrefs.GetFloat("currentTime") == 10)
        {
            maxTime = 9;
        }

        if (PlayerPrefs.GetFloat("currentTime") == 20)
        {
            maxTime = 8;
        }

        if (PlayerPrefs.GetFloat("currentTime") == 30)
        {
            maxTime = 7;
        }

        if (PlayerPrefs.GetFloat("currentTime") == 40)
        {
            maxTime = 6;
        }

        if (PlayerPrefs.GetFloat("currentTime") == 50)
        {
            maxTime = 5;
        }

        if (PlayerPrefs.GetFloat("currentTime") == 70)
        {
            maxTime = 4;
        }

    }


}
