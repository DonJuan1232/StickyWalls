using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame : MonoBehaviour
{
    public GameObject shop;
    public GameObject about;


    public void toGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        shop.SetActive(false);
        about.SetActive(false);
    }


    
}
