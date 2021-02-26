using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{

    int coin;

    public AudioSource coinsound;



    private void Start()
    {
        coin = 100;
    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            ScoreText.coinAmount += coin;
            coinsound.Play();
            Destroy(collision.gameObject);

        }
    }

    
}
