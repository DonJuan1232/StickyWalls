using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    Text text;
    public static int coinAmount;

    private void Start()
    {
        text = GetComponent<Text>();

    }

    private void Update()
    {

        coinAmount = PlayerPrefs.GetInt("CoinAmount");

        Debug.Log(coinAmount + " coinamount");

        PlayerPrefs.SetInt("CoinAmount", coinAmount);

        
    }

    /*private void Awake()  
    {
        PlayerPrefs.DeleteAll();
    }*/

}
