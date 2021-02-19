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
        coinAmount = PlayerPrefs.GetInt("CoinAmount", coinAmount);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("CoinAmount", coinAmount);

        text.text = coinAmount.ToString();
        
    }

    /*private void Awake()  
    {
        PlayerPrefs.DeleteAll();
    }*/

}
