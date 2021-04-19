using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{

    int coin;

    public AudioSource coinsound;



    private void Update()
    {
        if (PlayerPrefs.HasKey("coinValue"))
        {
            coin = PlayerPrefs.GetInt("coinValue");
        }
        else
        {
            coin = 1;
            PlayerPrefs.SetInt("coinValue", coin);
        }

        Debug.Log(coin + " coin");
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
