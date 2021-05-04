using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyPower : MonoBehaviour
{
    public int coins;

    public int powerNumber;

    public int powerBought1;
    public int powerBought2;
    public int powerBought3;

    public Text text1;
    public Text text2;
    public Text text3;

    // Start is called before the first frame update
    void Start()
    {
        powerNumber = 0;

    }

    // Update is called once per frame
    void Update()
    {
        coins = PlayerPrefs.GetInt("CoinAmount");

        powerNumber = PlayerPrefs.GetInt("powerNumber");

        powerBought1 = PlayerPrefs.GetInt("powerBought1");
        powerBought2 = PlayerPrefs.GetInt("powerBought2");
        powerBought3 = PlayerPrefs.GetInt("powerBought3");


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


        if(powerBought1 == 1)
        {
            text2.text = "Select power 1";
        }
        else
        {
            text2.text = "Buy power 1 150 coins";
        }

        if (powerBought3 == 1)
        {
            text3.text = "Select power 2";
        }
        else
        {
            text3.text = "Buy power 2 300 coins";
        }

        if(powerNumber != 0)
        {
            text1.text = "Select power 0";
        }

        if (powerNumber == 0)
        {
            text1.text = "Selected";
        }
        else if(powerNumber == 1)
        {
            text2.text = "selected";
        }
        else if (powerNumber == 3)
        {
            text3.text = "selected";
        }
    }

    //buy/select the power.

    public void power0()
    {

        powerNumber = 0;

        PlayerPrefs.SetInt("powerNumber", powerNumber);

        text1.text = "Selected";
        
        if(powerBought1 == 0)
        {
            text2.text = "Buy power 1 150 coins";
        }
        else
        {
            text2.text = "Select power 1";
        }

        if (powerBought3 == 1)
        {
            text3.text = "Select power 2";
        }
        else
        {
            text3.text = "Buy power 2 300 coins";
        }

    }

    public void power1()
    {
        if(powerBought1 == 0 && coins >= 150)
        {
            ScoreText.coinAmount -= 150;

            PlayerPrefs.SetInt("CoinAmount", coins);

            powerBought1 = 1;

            PlayerPrefs.SetInt("powerBought1", powerBought1);


            powerNumber = 1;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            text2.text = "Selected";

            text1.text = "Select power 0";

            if (powerBought3 == 1)
            {
                text3.text = "Select power 2";
            }
            else
            {
                text3.text = "Buy power 2 300 coins";
            }
        }
        else if(powerBought1 == 1)
        {
            powerNumber = 1;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            text2.text = "Selected";

            text1.text = "Select power 0";

            if (powerBought3 == 1)
            {
                text3.text = "Select power 2";
            }
            else
            {
                text3.text = "Buy power 2 300 coins";
            }
        }
    }


    public void power3()
    {
        if (powerBought3 == 0 && coins >= 300)
        {
            ScoreText.coinAmount -= 300;

            PlayerPrefs.SetInt("CoinAmount", coins);

            powerBought3 = 1;

            PlayerPrefs.SetInt("powerBought3", powerBought3);

            powerNumber = 3;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            text3.text = "Selected";

            text1.text = "Select power 0";

            if (powerBought1 == 1)
            {
                text2.text = "Select power 1";
            }
            else
            {
                text2.text = "Buy power 1 150 coins";

            }


        }
        else if (powerBought3 == 1)
        {
            powerNumber = 3;

            PlayerPrefs.SetInt("powerNumber", powerNumber);

            text3.text = "Selected";

            text1.text = "Select power 0";

            if (powerBought1 == 1)
            {
                text2.text = "Select power 1";
            }
            else
            {
                text2.text = "Buy power 1 150 coins";

            }
        }
    }
}



/*public void power2()
{
    if (powerBought2 == 0 && coins >= 1000)
    {
        ScoreText.coinAmount -= 1000;

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

        text3.text = "Selected";
    }
}*/
