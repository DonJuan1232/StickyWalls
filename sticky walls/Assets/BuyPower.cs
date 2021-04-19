using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyPower : MonoBehaviour
{
    public int coins;

    public int powerNumber;

    public int powerBought1;
    public int powerBought2;
    public int powerBought3;

    // Start is called before the first frame update
    void Start()
    {
        powerNumber = 0;


        /*PlayerPrefs.DeleteKey("powerBought1");
        PlayerPrefs.DeleteKey("powerBought2");*/
    }

    // Update is called once per frame
    void Update()
    {
        coins = PlayerPrefs.GetInt("CoinAmount");

        powerNumber = PlayerPrefs.GetInt("powerNumber");

        powerBought1 = PlayerPrefs.GetInt("powerBought1");
        powerBought2 = PlayerPrefs.GetInt("powerBought2");
        powerBought3 = PlayerPrefs.GetInt("powerBought3");

        Debug.Log(PlayerPrefs.GetInt("powerNumber"));

        if (PlayerPrefs.HasKey("powerNumber"))
        {
            powerNumber = PlayerPrefs.GetInt("powerNumber");
        }
        else
        {
            powerNumber = 0;
            PlayerPrefs.SetInt("powerNumber", powerNumber);
            //Debug.Log("works0");
        }


        if (PlayerPrefs.HasKey("powerBought1"))
        {
            powerBought1 = PlayerPrefs.GetInt("powerBought1");
        }
        else
        {
            powerBought1 = 0;
            PlayerPrefs.SetInt("powerBought1", powerBought1);
            //Debug.Log("works1");
        }



        if (PlayerPrefs.HasKey("powerBought2"))
        {
            powerBought2 = PlayerPrefs.GetInt("powerBought2");
        }
        else
        {
            powerBought2 = 0;
            PlayerPrefs.SetInt("powerBought2", powerBought2);
            //Debug.Log("works2");
        }

        if (PlayerPrefs.HasKey("powerBought3"))
        {
            powerBought3 = PlayerPrefs.GetInt("powerBought3");
        }
        else
        {
            powerBought3 = 0;
            PlayerPrefs.SetInt("powerBought3", powerBought3);
            //Debug.Log("works3");
        }
    }



    public void power0()
    {

        powerNumber = 0;

        PlayerPrefs.SetInt("powerNumber", powerNumber);

    }

    public void power1()
    {
        if(powerBought1 == 0 && coins >= 500)
        {
            coins -= 500;

            PlayerPrefs.SetInt("CoinAmount", coins);

            powerBought1 = 1;

            PlayerPrefs.SetInt("powerBought1", powerBought1);


            powerNumber = 1;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            //other color?
        }
        else if(powerBought1 == 1)
        {
            powerNumber = 1;

            PlayerPrefs.SetInt("powerNumber", powerNumber);
            //other color?
        }
    }


    public void power2()
    {
        if (powerBought2 == 0 && coins >= 1000)
        {
            coins -= 1000;

            PlayerPrefs.SetInt("CoinAmount", coins);

            powerBought2 = 1;

            PlayerPrefs.SetInt("powerBought2", powerBought2);

            powerNumber = 2;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            //other color?
        }
        else if(powerBought2 == 1)
        {
            powerNumber = 2;

            PlayerPrefs.SetInt("powerNumber", powerNumber);
            //other color?
        }
    }

    public void power3()
    {
        if (powerBought3 == 0 && coins >= 1000)
        {
            coins -= 1000;

            PlayerPrefs.SetInt("CoinAmount", coins);

            powerBought3 = 1;

            PlayerPrefs.SetInt("powerBought3", powerBought3);

            powerNumber = 2;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            //other color?
        }
        else if (powerBought3 == 1)
        {
            powerNumber = 3;

            PlayerPrefs.SetInt("powerNumber", powerNumber);
            //other color?
        }
    }

}
