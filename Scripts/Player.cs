using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour
{
    [SerializeField] GameObject TouchText;
    
    Touch touch;
    private Rigidbody2D _rigid;
   public static Player player;
   public CircleCollider2D circlecollider;
   [SerializeField] private GameObject FuelWarnText;
   private float MovementSpeed = 12f;
   [SerializeField] GameObject ScoreTextOption;
   [SerializeField] SpriteRenderer playerballoon;
   [SerializeField] Sprite[] BalloonSprite;
   public Camera mainCamera;
    public bool Isdead;
    [SerializeField] TrailRenderer renderer;
    [SerializeField] SpriteRenderer sprenderer;
    public bool PC;
    

private void Awake() {
       player = this;
}
void Start()
{
       Time.timeScale = 1;
       sprenderer = GetComponent<SpriteRenderer>();
       renderer = GetComponent<TrailRenderer>();
}
void Update()
{
    if(Isdead == true){
        Time.timeScale=0;
        AdsSkippable.instance.ShowInterstitialAd();
    }
    GetBalloonAndUpdatePlayer();  
}

void FixedUpdate()
{
    
        transform.position += new Vector3(touch.position.x,10*Time.deltaTime,0);
        if(PC){
           transform.position = new Vector3(mainCamera.ScreenToWorldPoint(Input.mousePosition).x*10*Time.deltaTime,transform.position.y,transform.position.z);
        }

    if(CamFollow.camfollow.target.position.y >= 3.41f){
        if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){
            transform.position = new Vector3(mainCamera.ScreenToWorldPoint(touch.position).x,transform.position.y,transform.position.z);
            }
        }
        if(transform.position.x >= 4.74f){
            transform.position = new Vector3(4.74f,transform.position.y);
        }
        if(transform.position.x <= -4.74f){
            transform.position = new Vector3(-4.74f,transform.position.y);
        }
    }
}
 void OnTriggerEnter2D(Collider2D other)
 {       
     if(other.CompareTag("Bomb")){
         if(PlayerPrefs.GetInt("Medal Point") == 50){
             MedalOptions.medalinstance.ImmuneCount--;
             StartCoroutine(PlayerImmune());
             if(MedalOptions.medalinstance.ImmuneCount < 0){
                 BombMethod();
             }
         }
            else{
                BombMethod();
            }
     }
      if(other.gameObject.CompareTag("Fuel")){
        Fuel.fuel.FuelValue += 30;
                if(Fuel.fuel.FuelValue <= 0){
                Fuel.fuel.FuelText.SetActive(false);
            }
                if(Fuel.fuel.FuelValue >= 100){
                    Fuel.fuel.FuelValue = 100;
                }
                Destroy(other.gameObject);
       }
       if(other.gameObject.CompareTag("Wall")){
           if(PlayerPrefs.GetInt("Medal Point") == 50){
             MedalOptions.medalinstance.ImmuneCount--;
             StartCoroutine(PlayerImmune());
             if(MedalOptions.medalinstance.ImmuneCount < 0){
              WallMethod();
             }
         }
            else{
                WallMethod();
            }
       }
 }

 public void BombMethod(){
     #region Bomb
        Handheld.Vibrate();
         Isdead = true;
         ScoreAndDie.Instance.Die();
         ScoreTextOption.SetActive(false);
         Fuel.fuel.FuelSliderGO.SetActive(false);
         FuelWarnText.SetActive(false);
         ScoreAndDie.Instance.MedalPointText.SetActive(false);
     #endregion
 }
 public void WallMethod(){
 #region Wall
         Isdead = true;
         Handheld.Vibrate();
         Fuel.fuel.FuelText.SetActive(false);
         ScoreAndDie.Instance.Die();
         ScoreTextOption.SetActive(false);
         FuelWarnText.SetActive(false);
         ScoreAndDie.Instance.MedalPointText.SetActive(false);
         Fuel.fuel.FuelSliderGO.SetActive(false);
     #endregion
 }
 public void DontDestroy(){
    if(player !=null){
        Destroy(gameObject);
        DontDestroyOnLoad(player);
        Fuel.fuel.FuelValue = 100;
        MedalOptions.medalinstance.ImmuneCount =1;
        Time.timeScale = 1;
            PlayerPrefs.SetInt("M", PlayerPrefs.GetInt("M") + ScoreAndDie.Instance.ScoreAmount);
        }
        else {
        DontDestroyOnLoad(player);
        MedalOptions.medalinstance.ImmuneCount =1;
        Time.timeScale = 1;
        }
        
    }
 private void GetBalloonAndUpdatePlayer(){
     
    if(Lobby.lobbyinstance.BalloonID == 1 && PlayerPrefs.GetInt("1") == 1){
        playerballoon.sprite = BalloonSprite[1];
    }
    if(Lobby.lobbyinstance.BalloonID == 2 && PlayerPrefs.GetInt("2") == 1){
        playerballoon.sprite = BalloonSprite[2];
    }
     if(Lobby.lobbyinstance.BalloonID == 3 && PlayerPrefs.GetInt("3") == 1){
        playerballoon.sprite = BalloonSprite[3];
    }
     if(Lobby.lobbyinstance.BalloonID == 4 && PlayerPrefs.GetInt("4") == 1){
        playerballoon.sprite = BalloonSprite[4];
    }
     if(Lobby.lobbyinstance.BalloonID == 5 && PlayerPrefs.GetInt("5") == 1){
        playerballoon.sprite = BalloonSprite[5];
    }
     if(Lobby.lobbyinstance.BalloonID == 6 && PlayerPrefs.GetInt("6") == 1){
        playerballoon.sprite = BalloonSprite[6];
    }
     if(Lobby.lobbyinstance.BalloonID == 7 && PlayerPrefs.GetInt("7") == 1){
        playerballoon.sprite = BalloonSprite[7];
    }
     if(Lobby.lobbyinstance.BalloonID == 8 && PlayerPrefs.GetInt("8") == 1){
        playerballoon.sprite = BalloonSprite[8];
    }
     if(Lobby.lobbyinstance.BalloonID == 9 && PlayerPrefs.GetInt("9") == 1){
        playerballoon.sprite = BalloonSprite[9];
    }
     if(Lobby.lobbyinstance.BalloonID == 10 && PlayerPrefs.GetInt("10") == 1){
        playerballoon.sprite = BalloonSprite[10];
    }
     if(Lobby.lobbyinstance.BalloonID == 11 && PlayerPrefs.GetInt("11") == 1){
        playerballoon.sprite = BalloonSprite[11];
    }
     if(Lobby.lobbyinstance.BalloonID == 12 && PlayerPrefs.GetInt("12") == 1){
        playerballoon.sprite = BalloonSprite[12];
    }
     if(Lobby.lobbyinstance.BalloonID == 13 && PlayerPrefs.GetInt("13") == 1){
        playerballoon.sprite = BalloonSprite[13];
    }
    if(Lobby.lobbyinstance.BalloonID == 14 && PlayerPrefs.GetString("Balloon14Sold")== "Yes"){ // paralı ürün
        renderer.enabled = true;
        playerballoon.sprite = BalloonSprite[14];
    }
    else
    {
        renderer.enabled = false;
    }
 }
IEnumerator PlayerImmune()
{
    yield return new WaitForSeconds(0.1f);
    sprenderer.enabled = false;
    yield return new WaitForSeconds(0.3f);
    sprenderer.enabled = true;
    yield return new WaitForSeconds(0.1f);
    sprenderer.enabled = false;
    yield return new WaitForSeconds(0.3f);
    sprenderer.enabled = true;
   
}
}