using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyInvis : MonoBehaviour
{
    public int coins;

    public int upgradeIvBuy1;

    public int bought;

    public Text text;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;



    public GameObject kt1;
    public GameObject kt2;
    public GameObject kt3;
    public GameObject kt4;
    public GameObject kt5;

    public void Start()
    {
        upgradeIvBuy1 = 1;
        bought = 1;


        if (PlayerPrefs.HasKey("UpgradeIVBuy"))
        {
            upgradeIvBuy1 = PlayerPrefs.GetInt("UpgradeIVBuy");
        }
        else
        {
            upgradeIvBuy1 = 1;
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);
            //Debug.Log("works1");
        }


        if (PlayerPrefs.HasKey("Bought2"))
        {
            bought = PlayerPrefs.GetInt("Bought2");
        }
        else
        {
            bought = 1;
            PlayerPrefs.SetInt("Bought2", bought);
            //Debug.Log("works2");
        }

        /*if (upgradeIvBuy1 != bought)
        {
            upgradeIvBuy1 = bought;
        }*/

    }

    public void Update()
    {
        coins = PlayerPrefs.GetInt("CoinAmount", coins);

        PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);
        upgradeIvBuy1 = PlayerPrefs.GetInt("UpgradeIVBuy");

        PlayerPrefs.SetInt("Bought2", bought);
        bought = PlayerPrefs.GetInt("Bought2");

    }


    public void buy1()
    {

        if (upgradeIvBuy1 == 1 && coins >= 25 && bought == 1)
        {
            //Level 1, 25 coins

            ScoreText.coinAmount -= 25;

            PlayerPrefs.SetInt("CoinAmount", coins);

            PlayerPrefs.SetFloat("WaitTime2", 5.5f);

            upgradeIvBuy1 = 2;
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);

            bought = 2;
            PlayerPrefs.SetInt("Bought2", bought);

            //after upgrade

            text2.text = "Press to upgrade invincibility to level 3";

            text.text = "50 coins";

            kt1.SetActive(false);
            kt2.SetActive(true);
            kt3.SetActive(false);
            kt4.SetActive(false);
            kt5.SetActive(false);


        }


    }


    public void buy2()
    {

        if (upgradeIvBuy1 == 2 && coins >= 50 && bought == 2)
        {
            //Level 2, 50 coins

            ScoreText.coinAmount -= 50;

            PlayerPrefs.SetInt("CoinAmount", coins);

            PlayerPrefs.SetFloat("WaitTime2", 6f);

            upgradeIvBuy1 = 3;
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);

            bought = 3;
            PlayerPrefs.SetInt("Bought2", bought);

            //after upgrade

            text3.text = "Press to upgrade invincibility to level 4";

            text.text = "100 coins";

            kt1.SetActive(false);
            kt2.SetActive(false);
            kt3.SetActive(true);
            kt4.SetActive(false);
            kt5.SetActive(false);

        }


    }

    public void buy3()
    {

        if (upgradeIvBuy1 == 3 && coins >= 100 && bought == 3)
        {
            //Level 3, 100 coins

            ScoreText.coinAmount -= 100;

            PlayerPrefs.SetInt("CoinAmount", coins);

            PlayerPrefs.SetFloat("WaitTime2", 6.5f);

            upgradeIvBuy1 = 4;
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);

            bought = 4;
            PlayerPrefs.SetInt("Bought2", bought);

            //after upgrade

            text4.text = "Press to upgrade invincibility to level 5";

            text.text = "200 coins";

            kt1.SetActive(false);
            kt2.SetActive(false);
            kt3.SetActive(false);
            kt4.SetActive(true);
            kt5.SetActive(false);



        }


    }

    public void buy4()
    {

        if (upgradeIvBuy1 == 4 && coins >= 200 && bought == 4)
        {
            //Level 4, 200 coins

            ScoreText.coinAmount -= 200;

            PlayerPrefs.SetInt("CoinAmount", coins);

            PlayerPrefs.SetFloat("WaitTime2", 7f);

            upgradeIvBuy1 = 5;
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);

            bought = 5;
            PlayerPrefs.SetInt("Bought2", bought);

            //after upgrade

            text5.text = "Press to upgrade invincibility to level 6";

            text.text = "300 coins";

            kt1.SetActive(false);
            kt2.SetActive(false);
            kt3.SetActive(false);
            kt4.SetActive(false);
            kt5.SetActive(true);

        }


    }

    public void buy5()
    {

        if (upgradeIvBuy1 == 5 && coins >= 300 && bought == 5)
        {
            //Level 5, 300 coins

            ScoreText.coinAmount -= 300;

            PlayerPrefs.SetInt("CoinAmount", coins);

            PlayerPrefs.SetFloat("WaitTime2", 7.5f);

            upgradeIvBuy1 = 6;
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeIvBuy1);

            bought = 6;
            PlayerPrefs.SetInt("Bought2", bought);

            //after upgrade

            text6.text = "You maxed out the invincibility upgrade!";

            text.text = "";

            kt1.SetActive(false);
            kt2.SetActive(false);
            kt3.SetActive(false);
            kt4.SetActive(false);
            kt5.SetActive(true);

        }


    }
}
