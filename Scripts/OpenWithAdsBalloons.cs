using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Advertisements; //Assuming you imported the Advertisements from the "Package Manager"
public class OpenWithAdsBalloons : MonoBehaviour, IUnityAdsListener
{
#if UNITY_IOS
    public string gameId = "Your-Apple-ID";
    public string mySurfacingId = "Rewarded_iOS";
#elif UNITY_ANDROID
    public string gameId = "4776634";
    public string mySurfacingId = "Rewarded_Android";
#endif
    private bool testMode = false; //Leave this as True UNTIL you release your game!!!

public static AdsRewarded instance;

 
    void Start()
    {
        Advertisement.AddListener(this);    //Used to check if Player COMPLETED the ad
        Advertisement.Initialize(gameId, testMode);     // Initialize the Ads listener and service:
    }
    
    public void ShowRewardedVideo() //Shows The add when this method is called - 
    {   // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(mySurfacingId)){
           if(Lobby.lobbyinstance.BalloonID == 2){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 3){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 4){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 5){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 6){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 7){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 8){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 9){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 10){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 11){
            Advertisement.Show(mySurfacingId);
           }
           if(Lobby.lobbyinstance.BalloonID == 12){
            Advertisement.Show(mySurfacingId);
           }
            
        } 
        else Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
    }
  #region AdsRewardedScriptttenDegistirilir
  #endregion
    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult) // Implement IUnityAdsListener interface methods:
    {
        if (showResult == ShowResult.Finished)
        {
           
            print("The Ad finished!!!");
          
        }
       
        else if (showResult == ShowResult.Failed) print("The Ad was interrupted or Failed.");
    }
    public void OnUnityAdsReady(string surfacingId) //Activates when ADD is ready
    {// If the ready Ad Unit or legacy Placement is rewarded, show the ad:        
        if (surfacingId == mySurfacingId)
        {// Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
            print("The Ad is ready");
            
        }
    }
    public void OnUnityAdsDidError(string message) // Log the error.
    {
        print("Something's wrong, it's... the Ad's not working!!!");
    }
    public void OnUnityAdsDidStart(string surfacingId) // Optional actions to take when the end-users triggers an ad.
    {
        print("this is extra");
    }
  
}