using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;

public class InitializeAds : MonoBehaviour
{
    [SerializeField] private GameObject restartOBJ;
    [SerializeField] private GameObject continueOBJ;
    [SerializeField] private AudioSource music;
    [SerializeField] private coinLogic script1;

    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardedAd rewardedAd;

    public void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
        this.RequestRewardedAd();
        this.RequestInterstitial();
    }
    ////// Banner /////////////////////////////////
    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-8112362826692397/5237638711";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
        string adUnitId = "unexpected_platform";
#endif
        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    public void killBanner()
    {
        bannerView.Destroy();
    }

    /// Interstitial ADS///////////////////////////////////////////////////////
    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-8112362826692397/8081625608";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpening;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
    }
    /// Interstitial CallBacks/////////////////////////////////////////////////////// 

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("Inter LOADED");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        restartOBJ.SetActive(true);

    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {
        music.Pause();

    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        music.Play();
        restartOBJ.SetActive(true);
    }
    /// Rewarded ADS/////////////////////////////////////////////////////// 

    public void RequestRewardedAd()
    {
        string adUnitId;
#if UNITY_ANDROID
            adUnitId = "ca-app-pub-8112362826692397/1199139595";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
        adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);


        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
    }

    //RewardedAd CALL BACKS/////////////////////////////////////////////////////////

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.Log("Couldnt Load Ad");
        music.Play();
        restartOBJ.SetActive(true);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        music.Pause();
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        Debug.Log("Couldn't Show Ad Rewarded");
        music.Play();
        restartOBJ.SetActive(true);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        music.Play();
        //restartOBJ.SetActive(true);
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {     

        continueOBJ.SetActive(true);
        script1.youHaveReward();
        script1.buttonset = script1.ButtonTemp;
        if (!continueOBJ.activeSelf)
        {
            restartOBJ.SetActive(true);
        }
    }

///LOAD ADS////////////////////////////////////////////////////

    public void LoadRewardedAd()
    {
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }

    public void LoadInterstitialAd()
    { 
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

///SHOW ADS//////////////////////////////////////////////

    public void showRewardedAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    public void ShowInterstitial()
    {
        
            this.interstitial.Show();
        
    }
}
