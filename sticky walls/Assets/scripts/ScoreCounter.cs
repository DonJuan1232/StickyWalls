using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreCounter : MonoBehaviour
{

    public float timeStart = 0;
    public Text textBox;
    public float currentTime;

    void Start()
    {
        textBox.text = timeStart.ToString();

        PlayerPrefs.DeleteKey("currentTime 00");

        /*Debug.Log(PlayerPrefs.GetFloat("highScore") + " highscore");
        Debug.Log(PlayerPrefs.GetFloat("currentTime") + " currenttime");*/

    }

    void Update()
    {
        timeStart += Time.deltaTime;
        float roundedTime = Mathf.Round(timeStart);
        currentTime = roundedTime;
        textBox.text = roundedTime.ToString();

        PlayerPrefs.SetFloat("currentTime", currentTime);

        
    }


}
