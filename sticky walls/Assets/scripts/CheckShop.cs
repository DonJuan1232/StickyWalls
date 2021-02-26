using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckShop : MonoBehaviour
{

    public int bought1;
    public int upgradeCrBuy2;

    public Text text;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;


    public int bought2;
    public int upgradeCrBuy3;

    public Text textI;
    public Text textI2;
    public Text textI3;
    public Text textI4;
    public Text textI5;
    public Text textI6;



    public void Start()
    {
        
        //coin rain check shop
        bought1 = PlayerPrefs.GetInt("Bought");
        upgradeCrBuy2 = PlayerPrefs.GetInt("UpgradeCrBuy");

        if (bought1 == 1 && upgradeCrBuy2 == 1)
        {
            PlayerPrefs.SetInt("UpgradeCrBuy", upgradeCrBuy2);
            PlayerPrefs.SetFloat("WaitTime", 5f);
            text.text = "25 coins";
            text2.text = "Press to upgrade coin rain to level 2";
            GetComponent<BuyCoinRain>().kt1.SetActive(true);
            GetComponent<BuyCoinRain>().kt2.SetActive(false);
            GetComponent<BuyCoinRain>().kt3.SetActive(false);
            GetComponent<BuyCoinRain>().kt4.SetActive(false);
            GetComponent<BuyCoinRain>().kt5.SetActive(false);
        }
        else if (bought1 == 2 && upgradeCrBuy2 == 2)
        {
            PlayerPrefs.SetInt("UpgradeCrBuy", upgradeCrBuy2);
            PlayerPrefs.SetFloat("WaitTime", 5.5f);
            text.text = "50 coins";
            text2.text = "Press to upgrade coin rain to level 3";
            GetComponent<BuyCoinRain>().kt1.SetActive(false);
            GetComponent<BuyCoinRain>().kt2.SetActive(true);
            GetComponent<BuyCoinRain>().kt3.SetActive(false);
            GetComponent<BuyCoinRain>().kt4.SetActive(false);
            GetComponent<BuyCoinRain>().kt5.SetActive(false);
        }
        else if (bought1 == 3 && upgradeCrBuy2 == 3)
        {
            PlayerPrefs.SetInt("UpgradeCrBuy", upgradeCrBuy2);
            PlayerPrefs.SetFloat("WaitTime", 6f);
            text.text = "100 coins";
            text3.text = "Press to upgrade coin rain to level 4";
            GetComponent<BuyCoinRain>().kt1.SetActive(false);
            GetComponent<BuyCoinRain>().kt2.SetActive(false);
            GetComponent<BuyCoinRain>().kt3.SetActive(true);
            GetComponent<BuyCoinRain>().kt4.SetActive(false);
            GetComponent<BuyCoinRain>().kt5.SetActive(false);
        }
        else if (bought1 == 4 && upgradeCrBuy2 == 4)
        {
            PlayerPrefs.SetInt("UpgradeCrBuy", upgradeCrBuy2);
            PlayerPrefs.SetFloat("WaitTime", 6.5f);
            text.text = "200 coins";
            text4.text = "Press to upgrade coin rain to level 5";
            GetComponent<BuyCoinRain>().kt1.SetActive(false);
            GetComponent<BuyCoinRain>().kt2.SetActive(false);
            GetComponent<BuyCoinRain>().kt3.SetActive(false);
            GetComponent<BuyCoinRain>().kt4.SetActive(true);
            GetComponent<BuyCoinRain>().kt5.SetActive(false);
        }
        else if (bought1 == 5 && upgradeCrBuy2 == 5)
        {
            PlayerPrefs.SetInt("UpgradeCrBuy", upgradeCrBuy2);
            PlayerPrefs.SetFloat("WaitTime", 7f);
            text.text = "300 coins";
            text5.text = "Press to buy coin rain level 6";
            GetComponent<BuyCoinRain>().kt1.SetActive(false);
            GetComponent<BuyCoinRain>().kt2.SetActive(false);
            GetComponent<BuyCoinRain>().kt3.SetActive(false);
            GetComponent<BuyCoinRain>().kt4.SetActive(false);
            GetComponent<BuyCoinRain>().kt5.SetActive(true);
        }
        else if (bought1 == 6 && upgradeCrBuy2 == 6)
        {
            PlayerPrefs.SetInt("UpgradeCrBuy", upgradeCrBuy2);
            PlayerPrefs.SetFloat("WaitTime", 7.5f);
            text.text = " ";
            text6.text = "You maxed out the Coin Rain upgrade!";
            GetComponent<BuyCoinRain>().kt1.SetActive(false);
            GetComponent<BuyCoinRain>().kt2.SetActive(false);
            GetComponent<BuyCoinRain>().kt3.SetActive(false);
            GetComponent<BuyCoinRain>().kt4.SetActive(false);
            GetComponent<BuyCoinRain>().kt5.SetActive(true);
        }



        //invis check shop
        bought2 = PlayerPrefs.GetInt("Bought2");
        upgradeCrBuy3 = PlayerPrefs.GetInt("UpgradeCrBuy");

        if (bought2 == 1 && upgradeCrBuy3 == 1)
        {
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeCrBuy3);
            PlayerPrefs.SetFloat("WaitTime2", 5f);
            textI.text = "25 coins";
            textI2.text = "Press to upgrade invincibility to level 2";
            GetComponent<BuyInvis>().kt1.SetActive(true);
            GetComponent<BuyInvis>().kt2.SetActive(false);
            GetComponent<BuyInvis>().kt3.SetActive(false);
            GetComponent<BuyInvis>().kt4.SetActive(false);
            GetComponent<BuyInvis>().kt5.SetActive(false);
        }
        else if (bought2 == 2 && upgradeCrBuy3 == 2)
        {
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeCrBuy3);
            PlayerPrefs.SetFloat("WaitTime2", 5.5f);
            textI.text = "50 coins";
            textI2.text = "Press to upgrade invincibility to level 3";
            GetComponent<BuyInvis>().kt1.SetActive(false);
            GetComponent<BuyInvis>().kt2.SetActive(true);
            GetComponent<BuyInvis>().kt3.SetActive(false);
            GetComponent<BuyInvis>().kt4.SetActive(false);
            GetComponent<BuyInvis>().kt5.SetActive(false);
        }
        else if (bought2 == 3 && upgradeCrBuy3 == 3)
        {
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeCrBuy3);
            PlayerPrefs.SetFloat("WaitTime2", 6f);
            textI.text = "100 coins";
            textI3.text = "Press to upgrade invincibility to level 4";
            GetComponent<BuyInvis>().kt1.SetActive(false);
            GetComponent<BuyInvis>().kt2.SetActive(false);
            GetComponent<BuyInvis>().kt3.SetActive(true);
            GetComponent<BuyInvis>().kt4.SetActive(false);
            GetComponent<BuyInvis>().kt5.SetActive(false);
        }
        else if (bought2 == 4 && upgradeCrBuy3 == 4)
        {
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeCrBuy3);
            PlayerPrefs.SetFloat("WaitTime2", 6.5f);
            textI.text = "200 coins";
            textI4.text = "Press to upgrade invincibility to level 5";
            GetComponent<BuyInvis>().kt1.SetActive(false);
            GetComponent<BuyInvis>().kt2.SetActive(false);
            GetComponent<BuyInvis>().kt3.SetActive(false);
            GetComponent<BuyInvis>().kt4.SetActive(true);
            GetComponent<BuyInvis>().kt5.SetActive(false);
        }
        else if (bought2 == 5 && upgradeCrBuy3 == 5)
        {
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeCrBuy3);
            PlayerPrefs.SetFloat("WaitTime2", 7f);
            textI.text = "300 coins";
            textI5.text = "Press to upgrade invincibility to level 6";
            GetComponent<BuyInvis>().kt1.SetActive(false);
            GetComponent<BuyInvis>().kt2.SetActive(false);
            GetComponent<BuyInvis>().kt3.SetActive(false);
            GetComponent<BuyInvis>().kt4.SetActive(false);
            GetComponent<BuyInvis>().kt5.SetActive(true);
        }
        else if (bought2 == 6 && upgradeCrBuy3 == 6)
        {
            PlayerPrefs.SetInt("UpgradeIVBuy", upgradeCrBuy3);
            PlayerPrefs.SetFloat("WaitTime2", 7.5f);
            textI.text = " ";
            textI6.text = "You maxed out the invincibility upgrade!";
            GetComponent<BuyInvis>().kt1.SetActive(false);
            GetComponent<BuyInvis>().kt2.SetActive(false);
            GetComponent<BuyInvis>().kt3.SetActive(false);
            GetComponent<BuyInvis>().kt4.SetActive(false);
            GetComponent<BuyInvis>().kt5.SetActive(true);
        }


    }

    public void Update()
    {
        bought1 = PlayerPrefs.GetInt("Bought");
        upgradeCrBuy2 = PlayerPrefs.GetInt("UpgradeCrBuy");

        bought2 = PlayerPrefs.GetInt("Bought2");
        upgradeCrBuy3 = PlayerPrefs.GetInt("UpgradeIVBuy");
    }

}
