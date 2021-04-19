using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{

    public int powerNumber;

    public Material material01;
    public Material material02;
    public Material material03;
    public Material material04;

    public float timeSpeed = 1.35f;

    public int coinValue;

    // Update is called once per frame
    void Start()
    {
        coinValue = PlayerPrefs.GetInt("coinValue");

        powerNumber = PlayerPrefs.GetInt("powerNumber");

        if(powerNumber == 0)
        {
            //Object.GetComponent<MeshRenderer>().material = material01;
            gameObject.GetComponent<MeshRenderer>().material = material01;

            coinValue = 1;
            PlayerPrefs.SetInt("coinValue", coinValue);
        }

        if(powerNumber == 1)
        {
            speedupTime();
            gameObject.GetComponent<MeshRenderer>().material = material02;

            coinValue = 1;
            PlayerPrefs.SetInt("coinValue", coinValue);
        }

        if(powerNumber == 2)
        {
            //second life?
            gameObject.GetComponent<MeshRenderer>().material = material03;

            coinValue = 1;
            PlayerPrefs.SetInt("coinValue", coinValue);
        }

        if(powerNumber == 3)
        {
            coinValue = 2;
            gameObject.GetComponent<MeshRenderer>().material = material04;

            PlayerPrefs.SetInt("coinValue", coinValue);
        }


    }


    void speedupTime()
    {
        Time.timeScale = timeSpeed;
    }



    public void OnCollisionEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
        }
    }


}
