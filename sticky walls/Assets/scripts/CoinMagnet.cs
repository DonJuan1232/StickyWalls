using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMagnet : MonoBehaviour
{

    

    public GameObject Player;

    public GameObject Coin;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }


    void Pickup()
    {
        

        


        Destroy(gameObject);
    }

}
