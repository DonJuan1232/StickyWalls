﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    
    public void toMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }


}
