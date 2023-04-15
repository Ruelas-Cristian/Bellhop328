using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceButton : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public GameObject circle4;
    public GameObject circle5;
    
    void Start()
    {
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        circle4.SetActive(false);
        circle5.SetActive(false);
    }

    // Update is called once per frame
    public void enableLed(int num){
        if(num == 1){
        circle1.SetActive(true);
        circle2.SetActive(false);
        circle3.SetActive(false);
        circle4.SetActive(false);
        circle5.SetActive(false);
        }
        if(num == 2){
        circle1.SetActive(false);
        circle2.SetActive(true);
        circle3.SetActive(false);
        circle4.SetActive(false);
        circle5.SetActive(false);  
        }
        if(num == 3){
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(true);
        circle4.SetActive(false);
        circle5.SetActive(false); 
        }
        if(num == 4){
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        circle4.SetActive(true);
        circle5.SetActive(false);
        }
        if(num == 5){
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        circle4.SetActive(false);
        circle5.SetActive(true);
        }
    }
}
