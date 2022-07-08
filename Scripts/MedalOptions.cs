using UnityEngine;
public class MedalOptions : MonoBehaviour{
    public static MedalOptions medalinstance;
    void Awake()
    {
        medalinstance = this;
    }
    public int ImmuneCount = 1;
    

   
    
}