using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
 [SerializeField] GameObject[] Objects;
[SerializeField] GameObject[] Positions;
public bool Cooldown = false;
private int RandomPos;
private int RandomObject;
private float spawntimer = 2.5f ;
GameObject obj;
 public static CloudSpawner _instance;
[SerializeField] Transform emptybox;
List<GameObject> Objectlist;

 
 void Awake()
 {
     Objects[0].SetActive(true);
    Objects[1].SetActive(true);
    Objects[2].SetActive(true);
 }
    void Start()
    {
        _instance = this;
        InvokeRepeating("Spawner",3.5f,spawntimer);
        
    }
void Update()
{
   
    print(Time.timeScale);
        RandomPos = Random.Range(1,Positions.Length);
        RandomObject = Random.Range(1,3);
        Objectlist = new List<GameObject>();
        Objectlist.Add(obj);
        Destroy(Objectlist[0],5);   
        StartCoroutine(StopSpawner());
}
    private void Spawner(){
       if(RandomPos == 1){
           if(RandomObject == 1){
             obj  =  Instantiate(Objects[0],Positions[0].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           if(RandomObject == 2){
               obj  =  Instantiate(Objects[1],Positions[0].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           if(RandomObject == 3){
               obj  =  Instantiate(Objects[2],Positions[0].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
        }
         if(RandomPos == 2){
           if(RandomObject == 1){
             obj  =  Instantiate(Objects[0],Positions[1].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           if(RandomObject == 2){
               obj  =  Instantiate(Objects[1],Positions[1].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           if(RandomObject == 3){
               obj  =  Instantiate(Objects[2],Positions[1].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
        }
         if(RandomPos == 3){
           if(RandomObject == 1){
             obj  =  Instantiate(Objects[0],Positions[2].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           if(RandomObject == 2){
               obj  =  Instantiate(Objects[1],Positions[2].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           if(RandomObject == 3){
               obj  =  Instantiate(Objects[2],Positions[2].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
        }
        
       
       if(Cooldown){
        CancelInvoke("Spawner");
       }
}
IEnumerator StopSpawner(){
  yield return null;
  /*
  
    yield return new WaitForSeconds(60);
    Objects[0].SetActive(false);
    Objects[1].SetActive(false);
    Objects[2].SetActive(false);
    */
}
}
