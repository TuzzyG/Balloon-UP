using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public static CamFollow camfollow;

    
    void Awake()
    {
        camfollow = this;
    }
     public float dampTime = 1f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    public Vector3 offset;
    public Vector3 Newoffset;

  void Update()
  {
  }
    private void FixedUpdate() {
       
          if (target)
         {
            if(target.position.y >= 3.41f){
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(new Vector3(0f,target.position.y));
            Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            if(target.transform.position.x <= 4){
             transform.position = Vector3.SmoothDamp(new Vector3(0,target.position.y,-1.44f), destination, ref velocity, dampTime);
                 transform.position = transform.position + offset;
            }
            if(target.transform.position.x >= 3.41f){
             transform.position = Vector3.SmoothDamp(new Vector3(0,target.position.y,-1.44f), destination, ref velocity, dampTime);
                   transform.position = transform.position + offset;
            }
            

            }
        }
        }
        
    }

