using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GoogleAds : MonoBehaviour
{

    int coins;
    static int counter = 0;
    public Button button;

    public GameObject Player;

    string enemyTag;

    int powerNumber;

    int coinamount = 20;

    string App_ID = "ca-app-pub-5441917585215554~5478256454";

    RewardedAd rewardedAdd;
    string RewardedAdd_ID = "ca-app-pub-3940256099942544/5224354917";

    RewardedAd rewardedAdd2;
    string RewardedAdd_ID2 = "ca-app-pub-3940256099942544/5224354917";

    InterstitialAd fullScreenAdd;
    string VideoAdd_ID = "ca-app-pub-3940256099942544/1033173712";


    public void Awake()
    {
        RequestInterstitial();

    }


    // Start is called before the first frame update
    public void Start()
    {

        MobileAds.Initialize(App_ID);

        coins = PlayerPrefs.GetInt("CoinAmount");

        this.rewardedAdd = new RewardedAd(RewardedAdd_ID);
        this.rewardedAdd2 = new RewardedAd(RewardedAdd_ID);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the rewarded ad with the request.
        this.rewardedAdd.LoadAd(request);

        this.rewardedAdd2.LoadAd(request);


        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAdd.OnUserEarnedReward += HandleUserEarnedReward;

        this.rewardedAdd2.OnUserEarnedReward += HandleUserEarnedReward2;

        // Called when the ad is closed.
        this.rewardedAdd2.OnAdClosed += HandleRewardedAdClosed;


        enemyTag = "Enemy";

        powerNumber = PlayerPrefs.GetInt("powerNumber");

    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        AdRequest request = new AdRequest.Builder().Build();


        this.rewardedAdd2.LoadAd(request);
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        //continue game
        if(powerNumber == 0 || powerNumber == 3 || powerNumber == 2)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 1.35f;
        }
        
        Player.GetComponent<FallCube>().continueGame();
        //showPlayer/enable
        Player.GetComponent<MeshRenderer>().enabled = true;
        Player.GetComponent<Collider>().enabled = true;
        Player.GetComponent<FallCube>().undoFreeze();


        Player.GetComponent<Movement>().WallTouchL = false;
        Player.GetComponent<Movement>().WallTouchR = false;

        Player.GetComponent<Transform>().position = new Vector3(6.42000055f, -2.5999999f, 18.6849709f);

        //delete all enemys etc
        DestroyGameObjects();


    }

    public void HandleUserEarnedReward2(object sender, Reward args)
    {


        ScoreText.coinAmount += coinamount;

        PlayerPrefs.SetInt("CoinAmount", coins);



    }

    public void DestroyGameObjects()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(enemyTag);
        foreach(GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
        }
    }


    public void RequestInterstitial()
    {
        // Initialize an InterstitialAd.
        this.fullScreenAdd = new InterstitialAd(VideoAdd_ID);


        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.fullScreenAdd.LoadAd(request);



    }

    public void ShowRequestRewarded()
    {

        if (this.rewardedAdd.IsLoaded())
        {
            this.rewardedAdd.Show();
        }

    }

    public void ShowRequestRewarded2()
    {

        if (this.rewardedAdd2.IsLoaded())
        {
            this.rewardedAdd2.Show();
        }



    }

    public void ShowInterstitialAd()
    {
        if (this.fullScreenAdd.IsLoaded())
        {
            this.fullScreenAdd.Show();
            Debug.Log("works2");
        }

        // Called when the ad is closed.
        this.fullScreenAdd.OnAdClosed += HandleOnAdClosed;

        Debug.Log("works3");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        SceneManager.LoadScene("GameScene");
    }



}
    
