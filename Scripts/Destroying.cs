using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{
    public AudioSource source;
    public AudioSource wall;
    public AudioSource Bomb;
    public AudioSource Fuel;



    
void OnTriggerEnter2D(Collider2D other)
{
    if(other.gameObject.CompareTag("Coin")){
        source.PlayOneShot(source.clip);
        Destroy(other.gameObject);

    }
    if(other.gameObject.CompareTag("Wall")){
        source.PlayOneShot(wall.clip);
    }
    if(other.gameObject.CompareTag("Bomb")){
        source.PlayOneShot(Bomb.clip);
    }
     if(other.gameObject.CompareTag("Fuel")){
        source.PlayOneShot(Fuel.clip);
    }
    
}
}
