using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{

    public GameObject menu;

    public GameObject countdown;
    public Text countdowntext;
    public int countdowntime = 3;


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
