using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class ShopConfig : MonoBehaviour {
[SerializeField] public GameObject[] Panel;
[SerializeField] TextMeshProUGUI Pricetext;
public static ShopConfig instance;
[SerializeField] TextMeshProUGUI YourMoney;
[SerializeField] GameObject NotenoughCoin;
[SerializeField] SpriteRenderer playerrenderer;
public int sold;
public int price;
public int Money;
    public int BalloonID1_Price;
    public int BalloonID2_Price;
    public int BalloonID3_Price;
    public int BalloonID4_Price;
    public int BalloonID5_Price;

    public int BalloonID6_Price;

    public int BalloonID7_Price;

    public int BalloonID8_Price;

    public int BalloonID9_Price;

    public int BalloonID10_Price;

    public int BalloonID11_Price;

    public int BalloonID12_Price;

    public int BalloonID13_Price;

    public int BalloonID14_Price;

    public int CASE_1;
    public int CASE_2;
    public int CASE_3;
    public int CASE_4;
    public int CASE_5;
    public int CASE_6;
    public int CASE_7;
    public int CASE_8;
    public int CASE_9;
    public int CASE_10;
    public int CASE_11;
    public int CASE_12;
    public int CASE_13;
    public int CASE_14;
    public int CASE_15;

    public AudioSource source;
void Awake()
{
    instance = this;
}
void Start()
{
   if(ScoreAndDie.Instance.ScoreAmount != 0){
   Money += ScoreAndDie.Instance.ScoreAmount;
        Money = PlayerPrefs.GetInt("M");
        }
        source = GameObject.Find("BuyBallonSound").GetComponent<AudioSource>();
    

    }
void Update()
{
CheckBalloonStatus();
print("PARA" + Money);
UpdateCase();
Money = PlayerPrefs.GetInt("M");
YourMoney.text = PlayerPrefs.GetInt("M").ToString();

PlayerPrefsCase();
}

public void BuywithCoin(){

    if(Lobby.lobbyinstance.BalloonID == 1){
        Pricetext.text = BalloonID1_Price.ToString();
        if(Money >= BalloonID1_Price){
            Money-= BalloonID1_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_1 = 1;
            PlayerPrefs.SetInt("1",CASE_1);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);
            print("satın alındı");
        }
        else
        {
                StartCoroutine(ErrorSale());
         }
        }
     if(Lobby.lobbyinstance.BalloonID == 2){

         Pricetext.text = BalloonID2_Price.ToString();
        if(Money >= BalloonID2_Price){
            Money-= BalloonID2_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_2 = 1;
            PlayerPrefs.SetInt("2",CASE_2);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
    if(Lobby.lobbyinstance.BalloonID == 3){

        Pricetext.text = BalloonID3_Price.ToString();
        if(Money >= BalloonID3_Price){
            Money-= BalloonID3_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_3 = 1;
            PlayerPrefs.SetInt("3",CASE_3);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 4){

         Pricetext.text = BalloonID4_Price.ToString();
        if(Money >= BalloonID4_Price){
            Money-= BalloonID4_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_4 = 1;
            PlayerPrefs.SetInt("4",CASE_4);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 5){

        if(Money >= BalloonID5_Price){
            Money-= BalloonID5_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_5 = 1;
            PlayerPrefs.SetInt("5",CASE_5);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 6){

         Pricetext.text = BalloonID6_Price.ToString();
        if(Money >= BalloonID6_Price){
            Money-= BalloonID6_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_6 = 1;
            PlayerPrefs.SetInt("6",CASE_6);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 7){

         Pricetext.text = BalloonID7_Price.ToString();
        if(Money >= BalloonID7_Price){
            Money-= BalloonID7_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_7 = 1;
            PlayerPrefs.SetInt("7",CASE_7);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 8){

         Pricetext.text = BalloonID8_Price.ToString();
        if(Money >= BalloonID8_Price){
            Money-= BalloonID8_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_8 = 1;
            PlayerPrefs.SetInt("8",CASE_8);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 9){

         Pricetext.text = BalloonID9_Price.ToString();
        if(Money >= BalloonID9_Price){
            Money-= BalloonID9_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_9 = 1;
            PlayerPrefs.SetInt("9",CASE_9);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {
                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 10){

         Pricetext.text = BalloonID10_Price.ToString();
        if(Money >= BalloonID10_Price){
            Money-= BalloonID10_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_10 = 1;
            PlayerPrefs.SetInt("10",CASE_10);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 11){

         Pricetext.text = BalloonID11_Price.ToString();
        if(Money >= BalloonID11_Price){
            Money-= BalloonID11_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_11 = 1;
            PlayerPrefs.SetInt("11",CASE_11);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());

            }
        }
     if(Lobby.lobbyinstance.BalloonID == 12){

         Pricetext.text = BalloonID12_Price.ToString();
        if(Money >= BalloonID12_Price){
            Money-= BalloonID12_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_12 = 1;
            PlayerPrefs.SetInt("12",CASE_12);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {

                StartCoroutine(ErrorSale());
        }
    }
     if(Lobby.lobbyinstance.BalloonID == 13){

         Pricetext.text = BalloonID13_Price.ToString();
        if(Money >= BalloonID13_Price){
            Money-= BalloonID13_Price;
            PlayerPrefs.SetInt("M",Money);
            CASE_13 = 1;
            PlayerPrefs.SetInt("13",CASE_13);
            GameObject.Find("BuyBallonSound").GetComponent<AudioSource>().PlayOneShot(source.clip);

            print("satın alındı");
        }
        else
        {
            StartCoroutine(ErrorSale());

        }
    }
    
   

}
private void PlayerPrefsCase(){
    PlayerPrefs.SetInt("1",CASE_1);
    PlayerPrefs.SetInt("2",CASE_2);
    PlayerPrefs.SetInt("3",CASE_3);
    PlayerPrefs.SetInt("4",CASE_4);
    PlayerPrefs.SetInt("5",CASE_5);
    PlayerPrefs.SetInt("6",CASE_6);
    PlayerPrefs.SetInt("7",CASE_7);
    PlayerPrefs.SetInt("8",CASE_8);
    PlayerPrefs.SetInt("9",CASE_9);
    PlayerPrefs.SetInt("10",CASE_10);
    PlayerPrefs.SetInt("11",CASE_11);
    PlayerPrefs.SetInt("12",CASE_12);
    PlayerPrefs.SetInt("13",CASE_13);
    PlayerPrefs.SetInt("14",CASE_14);
    PlayerPrefs.SetInt("15",CASE_15);

}
private void UpdateCase(){
    CASE_1 = PlayerPrefs.GetInt("1");
    CASE_2 = PlayerPrefs.GetInt("2");
    CASE_3 = PlayerPrefs.GetInt("3");
    CASE_4 = PlayerPrefs.GetInt("4");
    CASE_5 = PlayerPrefs.GetInt("5");
    CASE_6 = PlayerPrefs.GetInt("6");
    CASE_7 = PlayerPrefs.GetInt("7");
    CASE_8 = PlayerPrefs.GetInt("8");
    CASE_9 = PlayerPrefs.GetInt("9");
    CASE_10 = PlayerPrefs.GetInt("10");
    CASE_11 = PlayerPrefs.GetInt("11");
    CASE_12 = PlayerPrefs.GetInt("12");
    CASE_13 = PlayerPrefs.GetInt("13");
    CASE_14 = PlayerPrefs.GetInt("14");
    CASE_15 = PlayerPrefs.GetInt("15");

}
private void CheckBalloonStatus(){
    if(Lobby.lobbyinstance.BalloonID <= 0){
        Lobby.lobbyinstance.Items[1].SetActive(true);
        Panel[0].SetActive(false);
    }
    else
    {
        Lobby.lobbyinstance.Items[1].SetActive(false);
        Panel[0].SetActive(false);
    }
     if(Lobby.lobbyinstance.BalloonID == 1){
        if(PlayerPrefs.GetInt("1") == 0){

         Pricetext.text = BalloonID1_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("1") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }        
    }
    if(Lobby.lobbyinstance.BalloonID == 2){
        if(PlayerPrefs.GetInt("2") == 0){

         Pricetext.text = BalloonID2_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("2") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }        
    }
     if(Lobby.lobbyinstance.BalloonID == 3){
        if(PlayerPrefs.GetInt("3") == 0){

         Pricetext.text = BalloonID3_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("3") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 4){
        if(PlayerPrefs.GetInt("4") == 0){
         Pricetext.text = BalloonID4_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("4") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 5){
        if(PlayerPrefs.GetInt("5") == 0){
         Pricetext.text = BalloonID5_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("5") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 6){
        if(PlayerPrefs.GetInt("6") == 0){
         Pricetext.text = BalloonID6_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("6") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 7){

        if(PlayerPrefs.GetInt("7") == 0){
         Pricetext.text = BalloonID7_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("7") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 8){

        if(PlayerPrefs.GetInt("8") == 0){
         Pricetext.text = BalloonID8_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("8") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 9){
        if(PlayerPrefs.GetInt("9") == 0){
         Pricetext.text = BalloonID9_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("9") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 10){
        if(PlayerPrefs.GetInt("10") == 0){
         Pricetext.text = BalloonID10_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("10") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 11){
        if(PlayerPrefs.GetInt("11") == 0){
         Pricetext.text = BalloonID11_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("11") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 12){
        if(PlayerPrefs.GetInt("12") == 0){
         Pricetext.text = BalloonID12_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("12") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
     if(Lobby.lobbyinstance.BalloonID == 13){
        if(PlayerPrefs.GetInt("13") == 0){
         Pricetext.text = BalloonID13_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("13") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
   /*  if(Lobby.lobbyinstance.BalloonID == 14){
        if(PlayerPrefs.GetInt("14") == 0){
         Pricetext.text = BalloonID14_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("14") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
           
    }*/ // PARALI ÜRÜN
     if(Lobby.lobbyinstance.BalloonID == 15){
        if(PlayerPrefs.GetInt("15") == 0){
         Pricetext.text = BalloonID14_Price.ToString();
            Panel[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("15") == 1){
            Panel[0].SetActive(false);
         Lobby.lobbyinstance.Items[1].SetActive(true);
        }
        
    }
}
    IEnumerator ErrorSale()
    {
        yield return new WaitForSeconds(0.2f);
        NotenoughCoin.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        NotenoughCoin.SetActive(false);
    }
}


