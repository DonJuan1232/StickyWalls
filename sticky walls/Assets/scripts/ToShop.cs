using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToShop : MonoBehaviour
{

    public GameObject shop;
    public GameObject settings;
    public GameObject about1;
    public GameObject about2;

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

}
