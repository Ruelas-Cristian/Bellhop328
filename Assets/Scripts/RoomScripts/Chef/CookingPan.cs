using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingPan : MonoBehaviour
{
    private bool correct = true;
    private bool correctO = false;
    public int count = 0;
    public Sprite c;
    public Sprite w;
    public GameObject one;
    public GameObject two;
    public GameObject three; 
    public GameObject four;
    public GameObject five;
    public GameObject the;
    public GameObject none;
    public GameObject noneone;
    public GameObject nonetwo;
    public Transform T1;
    public Transform T2;
    public Transform T3;
    public Transform T4;
    public Transform T5;
    public Transform T6;
    public Transform T7;
    public Transform T8;
    public Transform T9;
    public Sprite original;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void cook(){
        Debug.Log(count);
        if(correct && count == 6){
            this.GetComponent<SpriteRenderer>().sprite = c;
            correctO = true;
        } else {
            this.GetComponent<SpriteRenderer>().sprite = w;
        }
        one.transform.position = T1.position;
        two.transform.position = T2.position;
        three.transform.position = T3.position;
        four.transform.position = T4.position;
        five.transform.position= T5.position;
        none.transform.position = T6.position;
        noneone.transform.position = T7.position;
        nonetwo.transform.position = T8.position;
        the.transform.position = T9.position;
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false); 
        four.SetActive(false);
        five.SetActive(false);
        none.SetActive(false);
        noneone.SetActive(false);
        nonetwo.SetActive(false);
        the.SetActive(false);
    }

    public void clean(){
        this.GetComponent<SpriteRenderer>().sprite = original;
        correct = true;
        one.SetActive(true);
        two.SetActive(true);
        three.SetActive(true); 
        four.SetActive(true);
        five.SetActive(true);
        none.SetActive(true);
        noneone.SetActive(true);
        nonetwo.SetActive(true);
        the.SetActive(true);
    }

    public bool checkifcorrect(){
        return correctO;
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Ingredent")){
            count += 1;
        } else if(other.CompareTag("Wrong")){
            correct = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Ingredent")){
            count -= 1;
        } else if(other.CompareTag("Wrong")){
            correct = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
