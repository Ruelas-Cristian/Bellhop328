using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Printer : MonoBehaviour, Interactable
{
    [SerializeField] TextMeshProUGUI TalkingText;
    public GameObject Sam;
    public Sprite paper;
    public Sprite printer1;
    public Sprite printer2;
    public GameObject viewport;
    public GameObject led;
    private bool printed = false;
    private bool haspaper = false;
    private bool hasink = false;
    private bool active = false;

    void Start()
    {
        viewport.SetActive(false);
        led.SetActive(true);
    }

    public void enable(){
        if(!printed){
        checkForPaper();
        } else if (!active){
            active = true;
            TalkingText.text = "";
            viewport.GetComponent<Image>().sprite = paper;
            viewport.SetActive(true);
            Invoke("DisableImage", 2.0f);
        } else {
            viewport.SetActive(false);
            active = false;
        }
    }

    public void disable(){
        if(!printed){
        checkForPaper();
        } else if (!active){
            active = true;
            TalkingText.text = "";
            viewport.GetComponent<Image>().sprite = paper;
            viewport.SetActive(true);
            Invoke("DisableImage", 2.0f);
        } else {
            viewport.SetActive(false);
            active = false;
        }
    }

    private void checkForPaper(){
        if(hasink && haspaper){
            TalkingText.text = "Printing";
            led.GetComponent<SpriteRenderer>().color = Color.yellow;
            Invoke("print", 3.0f);
        } else if(haspaper){
            TalkingText.text = "No Ink!";
            Invoke("stopPrinting", 3.0f);
        } else if(hasink){
            TalkingText.text = "No Paper!";
            Invoke("stopPrinting", 3.0f);
        } else {
            TalkingText.text = "Need Ink and Paper to Print";
            Invoke("stopPrinting", 3.0f);
        }
    }

    private void print(){
        led.GetComponent<SpriteRenderer>().color = Color.green;
        TalkingText.text = "Printing complete Press E To View";
        printed = true;
        Sam.GetComponent<SpriteRenderer>().sprite = printer2;
        Invoke("stopPrinting", 2.0f);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Draggable>() && other.CompareTag("Paper")){
            haspaper = true;
            Destroy(other.gameObject);
            Sam.GetComponent<SpriteRenderer>().sprite = printer1;
        } else if(other.GetComponent<Draggable>() && other.CompareTag("Ink")){
            led.GetComponent<SpriteRenderer>().color = Color.blue;
            hasink = true;
            Destroy(other.gameObject);
        }
    }

    public void stopPrinting(){
        TalkingText.text = "";
        
    }

    private void DisableImage(){
        viewport.SetActive(false);
    }


}
