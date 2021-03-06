﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool WallTouchL = false;
    public bool WallTouchR = false;


    public Rigidbody rb;

    public AudioSource jumpsound;


    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }



    public void right()
    {
        if (WallTouchR == true)
        {
            jumpsound.Play();
            rb.AddForce(-1500, 0, 0);
            new WaitForSeconds(0.5f);
            WallTouchR = false;

            
        }
    }

    public void left()
    {
        if (WallTouchL == true)
        {
            jumpsound.Play();
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
