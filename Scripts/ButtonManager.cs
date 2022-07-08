using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
     [SerializeField] GameObject[] Items;   
    
  public void BacktoMenu(){
      SceneManager.LoadScene("Lobby");
      Player.player.DontDestroy();
      
  }
  public void Replay(){
    SceneManager.LoadScene("InGame");
    Player.player.DontDestroy();
    PlayerPrefs.SetInt("Coin",ScoreAndDie.Instance.ScoreAmount);
  }

}
