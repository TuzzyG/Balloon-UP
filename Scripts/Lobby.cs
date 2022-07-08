using System;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;


public class Lobby : MonoBehaviour
{
    [SerializeField] public Sprite[] Balloon;
    [SerializeField] public GameObject[] Items;
    [SerializeField] RectTransform Circle;
    [SerializeField] RectTransform[] Transforms;
    [SerializeField] RectTransform LastTextPosition;
    [SerializeField] GameObject MiddleBalloonUI;
    [SerializeField] private GameObject PanelDown;
    [SerializeField] TextMeshProUGUI CountMedalText;
    [SerializeField] GameObject countmedal;
    [SerializeField] GameObject RewardMedalText;
    [SerializeField] Button MedalButton;
    [SerializeField] Button RewardButton;
    [SerializeField] GameObject TotalMedalCount;
    [SerializeField] GameObject MedalFeaturesPanel;
    public int BalloonIndex;
    public int BalloonID;
    public int Sold;
    public Text[] BalloonInfo;
    public static Lobby lobbyinstance;
    [SerializeField] public GameObject ShopPanelUI;
    [SerializeField] RectTransform[] LRButtonPosition;
    void Awake()
    {
      if(lobbyinstance ==null){
      lobbyinstance = this;
      }
      else{
        Destroy(this);
      }
    }
  
   void Update()
    {
      LChanger();
      RChanger();
     MedalButtonOP();
      #region BuywithAdsBalloon
      if(BalloonID == 2 &&PlayerPrefs.GetInt("M") >=50){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;
      }
      else if(BalloonID == 2 &&PlayerPrefs.GetInt("M") < 50){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
      }
      if(BalloonID == 3 &&PlayerPrefs.GetInt("M") >=125){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;
      }
     else if(BalloonID == 3 &&PlayerPrefs.GetInt("M") < 125){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
      }
      if(BalloonID == 4 &&PlayerPrefs.GetInt("M") >=250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;
        
      }
     else if(BalloonID == 4 &&PlayerPrefs.GetInt("M") < 250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 5 &&PlayerPrefs.GetInt("M") >=550){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
      else if(BalloonID == 5 &&PlayerPrefs.GetInt("M") < 550){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 6 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
      else if(BalloonID == 6 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 7 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
     else if(BalloonID == 7 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 8 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
     else if(BalloonID == 8 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 9 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
      else if(BalloonID == 9 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 10 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
      else if(BalloonID == 10 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 11 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
     else if(BalloonID == 11 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      if(BalloonID == 12 &&PlayerPrefs.GetInt("M") >=2250){
        GameObject.Find("GetReward").GetComponent<Button>().interactable = true;
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 1f;

      }
      else if(BalloonID == 12 &&PlayerPrefs.GetInt("M") < 2250){
        GameObject.Find("UnlockText").GetComponent<CanvasGroup>().alpha = 0.41f;
        GameObject.Find("GetReward").GetComponent<Button>().interactable = false;
      }
      
      #endregion
      
     if(BalloonID >= 14){
       ShopPanelUI.SetActive(false);
       if(PlayerPrefs.GetString("Balloon14Sold") == "Yes"){
         PanelDown.SetActive(true);
       }
     }
     if(BalloonID <=0){
       ShopPanelUI.SetActive(false);
       PanelDown.SetActive(true);
     }
    }
     public void RChanger(){
     if(BalloonIndex <0) BalloonIndex =0;
     if(BalloonIndex >= 15) BalloonIndex = 15;
     print(BalloonIndex);
     switch (BalloonIndex)
     {
       case 0:
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[0];
        BalloonIndex++;
        BalloonID = 0;
        Sold = 1;
         break;
       case 1: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[1];
        Sold = 0;
        BalloonID = 1;
        BalloonIndex++;
       break;
        case 2: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[2];
        BalloonID = 2;
        BalloonIndex++;
       break;
        case 3: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[3];
        Sold = 0;
        BalloonID = 3;
        BalloonIndex++;
       break;
        case 4: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[4];
        Sold = 0;
        BalloonID = 4;
        BalloonIndex++;
       break;
        case 5: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[5];
        Sold = 0;
        BalloonID = 5;
        BalloonIndex++;
       break;
        case 6: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[6];
        Sold = 0;
        BalloonID = 6;
        BalloonIndex++;
       break;
        case 7: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[7];
        Sold = 0;
        BalloonID = 7;
        BalloonIndex++;
       break;
        case 8: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[8];
        Sold = 0;
        BalloonID = 8;
        BalloonIndex++;
       break;
        case 9: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[9];
        Sold = 0;
        BalloonID = 9;
        BalloonIndex++;
       break;
        case 10: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[10];
        Sold = 0;
        BalloonID = 10;
        BalloonIndex++;
       break;
        case 11: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[11];
        Sold = 0;
        BalloonID = 11;
        BalloonIndex++;
       break;
        case 12: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[12];
        Sold = 0;
        BalloonID = 12;
        BalloonIndex++;
       break;
        case 13: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[13];
        Sold = 0;
        BalloonID = 13;
        BalloonIndex++;
       break;
       #region SaleCash
        case 14: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[14];
        Sold = 0;
        BalloonID = 14;
        BalloonIndex++;
       break;
       #endregion
       case 15: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[11];
       BalloonIndex++;
       BalloonID = 15;
       Sold = 0;
       break; 
    
     }return;
   }
     public void LChanger(){
     if(BalloonIndex <0) BalloonIndex =0;
     if(BalloonIndex >= 15) BalloonIndex = 15;
     print(BalloonIndex + "Balloon index");
     
     switch (BalloonIndex)
     {
       case 0:
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[0];
        Sold = 1;
        BalloonID = 0;
        BalloonIndex--;
         break;
       case 1: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[1];
        Sold = 1;
        BalloonID = 1;
        BalloonIndex--;
       break;
        case 2: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[2];
        Sold = 0;
        BalloonID = 2;
       BalloonIndex--;
       break;
        case 3: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[3];
        BalloonIndex--;
        BalloonID = 3;
        Sold = 0;
       break;
        case 4: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[4];
        BalloonIndex--;
        BalloonID = 4;
        Sold = 0;
       break;
        case 5: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[5];
       BalloonIndex--;
       Sold = 0;
       BalloonID = 5;
       break;
        case 6: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[6];
        BalloonIndex--;
        BalloonID = 6;
        Sold = 0;
       break;
        case 7: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[7];
        BalloonIndex--;
        BalloonID = 7;
        Sold = 0;
       break;
        case 8: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[8];
        BalloonIndex--;
        BalloonID = 8;
        Sold = 0;
       break;
        case 9: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[9];
        BalloonIndex--;
        BalloonID = 9;
        Sold = 0;
       break;
        case 10: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[10];
        BalloonIndex--;
        BalloonID = 10;
        Sold = 0;
       break;
        case 11: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[11];
        BalloonIndex--;
        BalloonID = 11;
        Sold = 0;
       break;
        case 12: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[12];
        BalloonIndex--;
        BalloonID = 12;
        Sold = 0;
       break;
        case 13: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[13];
        BalloonIndex--;
        BalloonID = 13;
        Sold = 0;
       break;
        case 14: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[14];
       BalloonIndex--;
       BalloonID = 14;
       Sold = 0;
       break;   
        case 15: 
        GameObject.Find("Balloon").GetComponent<Image>().sprite = Balloon[11];
       BalloonIndex--;
       BalloonID = 15;
       Sold = 0;
       break;
      
     }
       return;
     }
    public void Play(){
        StartCoroutine(PlayButton());
        PanelDown.transform.DOScale(0,0.6f);
    }
  IEnumerator PlayButton(){

     GameObject.Find("Music").SetActive(false);
      yield return new WaitForSecondsRealtime(1f);
      Items[0].SetActive(false);
      Items[1].SetActive(false);
      Items[4].SetActive(true);

        Items[6].SetActive(false);
    yield return new WaitForSecondsRealtime(1.2f);
    Circle.DOScale(0,1.7f).SetEase(Ease.OutBack);
    Items[5].GetComponent<Text>().text = "2";
    Circle.DOScale(1,1.7f).SetEase(Ease.InBack);

        yield return new WaitForSecondsRealtime(1.2f);
    Circle.DOScale(0,1.7f).SetEase(Ease.OutBack);
    LastTextPosition.DOLocalMoveX(116.15f,0);
    Items[5].GetComponent<Text>().text = " 1";
    Circle.DOScale(1,1.7f).SetEase(Ease.InBack);
      
      yield return new WaitForSecondsRealtime(1.5f);
      SceneManager.LoadScene(2);
}
    #region MedalPoint 
    private void MedalButtonOP()
    {
        if (PlayerPrefs.GetInt("Medal Point") >= 50)
        {
          PlayerPrefs.SetInt("Medal Point",50);
            MedalButton.interactable = true;
            countmedal.SetActive(false);
            TotalMedalCount.SetActive(false);
            RewardMedalText.SetActive(false);
        }
        else
        {
            MedalButton.interactable = false;
        }
        CountMedalText.text = PlayerPrefs.GetInt("Medal Point").ToString();
    }

   
    #endregion
    public bool ispanelactive = false;
   public void MedalFeaturesPanelButton(){
    if(PlayerPrefs.GetInt("Medal Point") == 50){
      if(!ispanelactive){
        MedalFeaturesPanel.SetActive(true);
        ispanelactive = true;
      }
  }
  }
  public void CloseFeaturePanel(){
    if(ispanelactive == true){
      MedalFeaturesPanel.SetActive(false);
      ispanelactive = false;
    }
    ButtonSound.btninstance.Sound();
  }
}
