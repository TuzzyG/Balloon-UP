using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random= UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
[SerializeField] GameObject[] Objects;
[SerializeField] GameObject[] Positions;
[SerializeField] float SpawnDelay;
public bool Cooldown = false;
private int RandomPos;
private int RandomObject;
private float spawntimer = 1.5f ;
public Camera Cam;
GameObject obj;
[SerializeField] Text Scoretext;
private int ScoreCount = 1;

[SerializeField] Transform emptybox;
List<GameObject> Objectlist;

    void Awake()
    {
        Scoretext = GetComponent<Text>();
    }
 
    void Start()
    {
        InvokeRepeating("Spawner",1.7f,spawntimer);
    }
void Update()
{
        RandomPos = Random.Range(1,Positions.Length);
        RandomObject = Random.Range(1,3);
        Objectlist = new List<GameObject>();
        Objectlist.Add(obj);
        Destroy(Objectlist[0],5);   
}
    private void Spawner(){
        if(GameObject.Find("Player").transform.position.y >=3.41f) {
            spawntimer -= 0.4f;
            if(spawntimer <=0){
            spawntimer = 0;
                Time.timeScale += 0.0105f;
            }
            if(Time.timeScale >= 2.1f){
                Time.timeScale = 2.1f;
            }
        }
       if(RandomPos == 1){
           if(RandomObject == 1){
             obj  =  Instantiate(Objects[0],Positions[0].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           else {
                obj  = Instantiate(Objects[1],Positions[0].transform.position,transform.rotation);
                obj.transform.parent = emptybox.transform;
           }
       }
       if(RandomPos == 2){
           if(RandomObject == 1){
                obj  =  Instantiate(Objects[0],Positions[1].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           else {
                obj  = Instantiate(Objects[1],Positions[1].transform.position,transform.rotation);
                obj.transform.parent = emptybox.transform;
           }
       }
       if(RandomPos == 3){
           if(RandomObject == 1){
               obj  =  Instantiate(Objects[0],Positions[2].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           else {
                obj  = Instantiate(Objects[1],Positions[2].transform.position,transform.rotation);
                obj.transform.parent = emptybox.transform;
           }
       }
       if(RandomPos == 4){
           if(RandomObject == 1){
                obj  =  Instantiate(Objects[0],Positions[3].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           else {
                obj  = Instantiate(Objects[1],Positions[3].transform.position,transform.rotation);
                obj.transform.parent = emptybox.transform;
           }
       }
       if(RandomPos == 5){
           if(RandomObject == 1){
                obj  =  Instantiate(Objects[0],Positions[4].transform.position,transform.rotation);
             obj.transform.parent = emptybox.transform;
           }
           else {
                obj  = Instantiate(Objects[1],Positions[4].transform.position,transform.rotation);
                obj.transform.parent = emptybox.transform;
           }
       }
       if(Cooldown){
        CancelInvoke("Spawner");
       }
}
}