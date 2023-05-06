using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFood : MonoBehaviour
{
    public Transform T1;
    public Transform T2;
    public Transform T3;
    public Transform T4;
    public Transform T5;
    public Transform T6;
    public Transform T7;
    public Transform T8;
    public GameObject ONE;
    public GameObject TWO;
    public GameObject THREE;
    public GameObject FOUR;
    public GameObject FIVE;
    public GameObject the;
    public GameObject SEVEN;
    public GameObject EIGHT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void respawn(){
        ONE.transform.localPosition = T1.localPosition;
        TWO.transform.localPosition = T2.localPosition;
        THREE.transform.localPosition = T3.localPosition;
        FOUR.transform.localPosition = T4.localPosition;
        FIVE.transform.localPosition = T5.localPosition;
        the.transform.localPosition = T6.localPosition;
        SEVEN.transform.localPosition = T7.localPosition;
        EIGHT.transform.localPosition = T8.localPosition;
        ONE.SetActive(true);
        TWO.SetActive(true);
        THREE.SetActive(true);
        FOUR.SetActive(true);
        FIVE.SetActive(true);
        the.SetActive(true);
        SEVEN.SetActive(true);
        EIGHT.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
