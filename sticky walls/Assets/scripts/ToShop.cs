using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToShop : MonoBehaviour
{

    public GameObject shop;
    public GameObject settings;
    public GameObject about1;
    public GameObject about2;

    public GameObject power0;
    public GameObject power1;
    public GameObject power2;

    public void toShop()
    {
        shop.SetActive(true);

        if (settings.activeSelf)
        {
            settings.SetActive(false);
        }
    }

    public void toMenu()
    {
        shop.SetActive(false);

        if (about1.activeSelf)
        {
            about1.SetActive(false);
        }

        if (about2.activeSelf)
        {
            about2.SetActive(false);
        }
    }


    //settings
    public void toSettings()
    {
        settings.SetActive(true);

        if (shop.activeSelf)
        {
            shop.SetActive(false);
        }
    }

    public void toMenu2()
    {
        settings.SetActive(false);
    }

    public void toAboutCr()
    {
        about1.SetActive(true);
    }

    public void toAboutCr2()
    {
        about1.SetActive(false);
    }


    public void toAboutInvis()
    {
        about2.SetActive(true);
    }

    public void toAboutInvis2()
    {
        about2.SetActive(false);
    }


    //power0
    public void toPower0()
    {
        power0.SetActive(true);

        if (power1.activeSelf || power2.activeSelf)
        {
            power1.SetActive(false);
            power2.SetActive(false);
        }
    }

    public void toPower01()
    {
        power0.SetActive(false);
    }


    //power1
    public void toPower1()
    {
        power1.SetActive(true);

        if (power0.activeSelf || power2.activeSelf)
        {
            power0.SetActive(false);
            power2.SetActive(false);
        }
    }

    public void toPower11()
    {
        power1.SetActive(false);
    }


    //power2
    public void toPower2()
    {
        power2.SetActive(true);

        if (power0.activeSelf || power1.activeSelf)
        {
            power0.SetActive(false);
            power1.SetActive(false);
        }
    }

    public void toPower21()
    {
        power2.SetActive(false);
    }



}
