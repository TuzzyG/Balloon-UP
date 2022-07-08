using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
  public  AudioClip clip;
  public static ButtonSound btninstance;
  [SerializeField] private AudioSource source;
   
   void Start()
   {
     btninstance = this;
   }
public void Sound(){
    source.PlayOneShot(clip);
}


}
