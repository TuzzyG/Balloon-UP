using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
public static Bomb bomb;
public bool isdead = false;


    public void Die(){
        Time.timeScale = 0;
        isdead = true;

    }
}
