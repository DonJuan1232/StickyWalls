using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFall : MonoBehaviour
{
    public Rigidbody rb;
    public float fallspeed = -7f;

    void Update()
    {
        rb.AddForce(0, fallspeed, 0);
    }
}
