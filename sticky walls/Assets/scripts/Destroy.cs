using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Coin" || other.gameObject.tag == "invis" || other.gameObject.tag == "CoinRain")
        {
            Destroy(other.gameObject);
        }
    }
}
