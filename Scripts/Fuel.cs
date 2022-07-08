using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Fuel : MonoBehaviour
{
    public static Fuel fuel;
    [SerializeField] public Slider FuelSlider;
    [SerializeField] public GameObject FuelSliderGO;
    [SerializeField] private GameObject DiePanel;
    public float FuelValue = 100;
    [SerializeField] public GameObject FuelText;
    void Awake()
    {
        fuel = this;
    }
    void Start()
    {
        FuelSlider.value = FuelValue;
    }
    void Update()
    {
        FuelSystem();
    }
   private void FuelSystem(){
       FuelValue -= 3f * Time.deltaTime;
        FuelSlider.value = FuelValue;
       if(FuelValue <= 0){
           Time.timeScale = 0;
           DiePanel.SetActive(true);
       }
       if(FuelValue <= 40){
        FuelText.SetActive(true);
       }
       if(FuelValue >= 40){
           FuelText.SetActive(false);
       }
       if(FuelValue <= 0){
           FuelText.SetActive(false);
       }
   }
  
}
