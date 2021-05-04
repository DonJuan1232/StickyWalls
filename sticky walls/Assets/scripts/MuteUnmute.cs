using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MuteUnmute : MonoBehaviour
{

    public int muted;

    public GameObject muteIcon;
    public GameObject unmuteIcon;

    public void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            muted = PlayerPrefs.GetInt("muted");
        }
        else
        {
            muted = 0;
            PlayerPrefs.SetInt("muted", muted);

        }

        if(muted == 1)
        {
            AudioListener.volume = 0;
            muteIcon.SetActive(true);
            unmuteIcon.SetActive(false);
        }
        else
        {
            AudioListener.volume = 1;
            muteIcon.SetActive(false);
            unmuteIcon.SetActive(true);
        }



    }

    /*public void Update()
    {
        Debug.Log("mute1 " + PlayerPrefs.GetInt("muted"));
        Debug.Log("mute2 " + muted);
    }*/


    public void mute()
    {
        if (muted == 1)
        {
            muted = 0;
            PlayerPrefs.SetInt("muted", muted);
            muteIcon.SetActive(false);
            unmuteIcon.SetActive(true);
        }
        else
        {
            muted = 1;
            PlayerPrefs.SetInt("muted", muted);
            muteIcon.SetActive(true);
            unmuteIcon.SetActive(false);

        }
    }


}
