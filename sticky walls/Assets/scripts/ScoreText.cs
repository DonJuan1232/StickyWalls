using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    public Text text;
    string text2;
    public static int coinAmount;

    private void Start()
    {

        coinAmount = PlayerPrefs.GetInt("CoinAmount");

    }

    private void Update()
    {

        text2 = coinAmount.ToString();

        text.text = text2;

        PlayerPrefs.SetInt("CoinAmount", coinAmount);

        
    }

    /*private void Awake()  
    {
        PlayerPrefs.DeleteAll();
    }*/

}
