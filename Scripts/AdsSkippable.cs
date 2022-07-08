using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; //Assuming you imported the Advertisements from the "Package Manager"

public class AdsSkippable : MonoBehaviour
{
    public static AdsSkippable instance;
#if UNITY_IOS
    public string gameId = "Your-Apple-ID";
    public string mySurfacingId = "Interstitial_iOS";
#elif UNITY_ANDROID
    public string gameId = "4776634";
    public string mySurfacingId = "Interstitial_Android";
#endif
    private bool testMode = false; //Leave this as True UNTIL you publicly release your game!!!
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Advertisement.Initialize(gameId, testMode); //Prepares Everything Immediately
    }
    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady()) // Check if UnityAds ready before calling Show method:
        {
            Advertisement.Show(mySurfacingId);
            print("You're watching an AD!!!");
            Player.player.Isdead = false;
        }
               else print("Interstitial ad not ready at the moment! Please try again later!");
    }
   
}