using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public int muted;

    public void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            muted = PlayerPrefs.GetInt("muted");
        }

        if (muted == 1)
        {
            AudioListener.volume = 0;

        }
        else
        {
            AudioListener.volume = 1;

        }


        /*Debug.Log("mute1 " + PlayerPrefs.GetInt("muted"));
        Debug.Log("mute2 " + muted);*/
    }



}
