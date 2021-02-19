using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    

    public Text highScoreText;
    public float highScore;
    public float currentScore;

    public void Awake()
    {
        highScoreText = GetComponent<Text>();
    }

    public void Start()
    {
        currentScore = PlayerPrefs.GetFloat("currentTime");
        highScore = PlayerPrefs.GetFloat("highScore");
    }

    public void Update()
    {
        
        

        if (PlayerPrefs.HasKey("highScore"))
        {
            if (currentScore >= highScore)
            {
                highScore = currentScore;
                PlayerPrefs.SetFloat("highScore", highScore);

                highScoreText.text = highScore.ToString();
            }
        }
        else
        {
            highScore = 1;
            PlayerPrefs.SetFloat("highScore", highScore);
        }

        highScoreText.text = highScore.ToString();
    }


}
