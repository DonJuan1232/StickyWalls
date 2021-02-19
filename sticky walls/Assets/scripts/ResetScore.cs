using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public void resetScore()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("CoinAmount");
    }
}
