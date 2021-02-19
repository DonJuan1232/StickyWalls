using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToShop : MonoBehaviour
{

    public GameObject shop;
    public GameObject settings;

    public void toShop()
    {
        shop.SetActive(true);
    }

    public void toMenu()
    {
        shop.SetActive(false);
    }


    //settings
    public void toSettings()
    {
        settings.SetActive(true);
    }

    public void toMenu2()
    {
        settings.SetActive(false);
    }

}
