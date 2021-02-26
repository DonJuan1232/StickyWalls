using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using System;

public class GoogleAds : MonoBehaviour
{

    string App_ID = "ca-app-pub-5441917585215554~5478256454";

    string VideoAdd = "ca-app-pub-5441917585215554/1857958069"; 

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(App_ID);
    }

    public void rewardedvideo()
    {
        
    }

}
    
