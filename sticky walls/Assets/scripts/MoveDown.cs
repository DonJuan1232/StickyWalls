using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        rb.AddForce(0, -10, 0);
    }
}
