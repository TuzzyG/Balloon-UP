using UnityEngine;
using TMPro;
using UnityEngine.Purchasing;
public class BuywithCash : MonoBehaviour
{
[SerializeField] GameObject CashPanel;
[SerializeField] GameObject DownPanel;
 public TextMeshProUGUI[] Properties;
 
 public string[] Data;
 [SerializeField] GameObject[] IAPButtons;
void Update()
{
    SaleController();
    SalePanelController();
}
public void SuccesSale(Product productid){ // Ürün ekle
  if(Lobby.lobbyinstance.BalloonID == 14){
      if(productid.definition.id == "com.dubbedx.balloonup.stballoon"){
          print("Satın Alındı");
          PlayerPrefs.SetString("Balloon14Sold","Yes");
      }
  }
}
 private void BalloonProperties(){ // özellikleri
     if(Lobby.lobbyinstance.BalloonID == 14){
        Properties[0].text = "8 coin more gain";
        Properties[1].text = "trail effect";
        Properties[2].text = "";
     }
 }
 private void SaleController(){ // Satın alınmış ürünleri veride kontrol etmek
     Data[0] = PlayerPrefs.GetString("Balloon14Sold");
 }
private void SalePanelController(){ // hem butonlar hem de satın alınmış ürünlerin panellerini kapatma
    if(Lobby.lobbyinstance.BalloonID == 14){
    if(PlayerPrefs.GetString("Balloon14Sold") == "Yes"){
        print("Satın Alınmış");
        CashPanel.SetActive(false);
        Lobby.lobbyinstance.ShopPanelUI.SetActive(false);
        DownPanel.SetActive(true);
    }
    else if (PlayerPrefs.GetString("Balloon14Sold") != "Yes"){
        print("Satın Alınmamış");
        DownPanel.SetActive(false);
        IAPButtons[0].SetActive(true);
        Lobby.lobbyinstance.ShopPanelUI.SetActive(false);
        CashPanel.SetActive(true);
    }

    }
   if(Lobby.lobbyinstance.BalloonID <= 13){ // 13 den aşağısını komple panelleri kapat
      CashPanel.SetActive(false);
    }
    
}
}
