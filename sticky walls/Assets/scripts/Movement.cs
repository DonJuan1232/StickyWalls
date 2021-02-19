using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool WallTouchL = false;
    bool WallTouchR = false;


    public Rigidbody rb;



    public void right()
    {
        if (WallTouchR == true)
        {            
            rb.AddForce(-1500, 0, 0);
            new WaitForSeconds(0.5f);
            WallTouchR = false;

            
        }
    }

    public void left()
    {
        if (WallTouchL == true)
        {
            rb.AddForce(1500, 0, 0);
            new WaitForSeconds(0.5f);
            WallTouchL = false;
            

        }
        
    }


    void OnCollisionEnter(Collision hit)
    {
        if (hit.transform.gameObject.tag == "WallR")
        {
            WallTouchR = true;
            
        }

        if (hit.transform.gameObject.tag == "WallL")
        {
            WallTouchL = true;
            

        }
    }

    



}
