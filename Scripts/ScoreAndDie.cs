using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreAndDie : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Scoretext;
    public  int ScoreAmount =0;
    public int MedalPoint = 0;
    public int Medal;
    public static ScoreAndDie Instance;
    [SerializeField] private GameObject DiePanel;
    [SerializeField] public TextMeshProUGUI collectedCoin;
    [SerializeField] TextMeshProUGUI MaxScoreCoin;
    [SerializeField] public GameObject MedalPointText;
    void Awake()
    {
        Instance = this;
         MaxScoreCoin.text = PlayerPrefs.GetInt("High Score", 0).ToString();
         
    }
    private void Update() {
       if(ScoreAmount>PlayerPrefs.GetInt("High Score", 0))
        {
            PlayerPrefs.SetInt("High Score", ScoreAmount);
            MaxScoreCoin.text = ScoreAmount.ToString();
        }
        PlayerPrefs.SetInt("Coin",ScoreAmount);
    }
   
    public void AddScore(){
        if(PlayerPrefs.GetInt("Medal Point") >=50){
            if(Lobby.lobbyinstance.BalloonID <= 13){
            ScoreAmount+=4;
            }
        }
        else{
            ScoreAmount +=1;
        }
        // Paralı ürünlerin özellikleri
        if(Lobby.lobbyinstance.BalloonID == 14){
            if(PlayerPrefs.GetString("Balloon14Sold") == "Yes"){
               if(ScoreAmount == 40){
                    MedalPointText.SetActive(true);
                    StartCoroutine(MedalText()); 
                }
                ScoreAmount+=8;
            }
        }
        if(PlayerPrefs.GetInt("Medal Point") == 50)
        {
            MedalPointText.SetActive(false);
        }
        Scoretext.text = ScoreAmount.ToString();
      collectedCoin.text = ScoreAmount.ToString();
      if(ScoreAmount == 50){
       MedalPointText.SetActive(true);
       StartCoroutine(MedalText());
   }
   
    else if(PlayerPrefs.GetInt("Medal Point") >= 50 && ScoreAmount == 52){
       MedalPointText.SetActive(true);
       StartCoroutine(MedalText());
    }
         SetMedalScore();
    }
   public void Die(){
       Time.timeScale = 0;
       DiePanel.SetActive(true);
   }
private void SetMedalScore(){
        if(PlayerPrefs.GetInt("Medal Point") == 50 && ScoreAmount == 52 || PlayerPrefs.GetInt("Medal Point") != 50 && ScoreAmount == 50 || Lobby.lobbyinstance.BalloonID == 14 && ScoreAmount == 48)
        {
            MedalPoint = 1;
            PlayerPrefs.SetInt("Medal Point", MedalPoint + PlayerPrefs.GetInt("Medal Point"));
        }

    }
    IEnumerator MedalText()
  {
        yield return new WaitForSeconds(5f);
        MedalPointText.SetActive(false);
  }
 
}