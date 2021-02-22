using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRain : MonoBehaviour
{
    public float waitTime;

    public GameObject coinspawner1;
    public GameObject coinspawner2;
    public GameObject coinspawner3;
    public GameObject coinspawner4;

    public AudioSource coinrainsound;

    public void Start()
    {
        waitTime = 8;
        waitTime = PlayerPrefs.GetFloat("WaitTime");
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CoinRain")
        {
            coinrainsound.Play();
            StartCoroutine(coinRain());
            Destroy(other.gameObject);
        }
    }

    IEnumerator coinRain()
    {
        coinspawner1.GetComponent<CoinSpawner2>().maxTime = 3;
        coinspawner2.GetComponent<CoinSpawner2>().maxTime = 3;
        coinspawner3.GetComponent<CoinSpawner2>().maxTime = 3;
        coinspawner4.GetComponent<CoinSpawner2>().maxTime = 3;


        yield return new WaitForSeconds(waitTime);

        coinspawner1.GetComponent<CoinSpawner2>().maxTime = 15;
        coinspawner2.GetComponent<CoinSpawner2>().maxTime = 15;
        coinspawner3.GetComponent<CoinSpawner2>().maxTime = 15;
        coinspawner4.GetComponent<CoinSpawner2>().maxTime = 15;

        yield return 0;
    }

}
