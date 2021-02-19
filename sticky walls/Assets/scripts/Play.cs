using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    public GameObject menu;


    public void PauseGame()
    {
        Time.timeScale = 0;

        menu.SetActive(true);
    }

    public void Continue()
    {
        Time.timeScale = 1;

        menu.SetActive(false);
    }


}
