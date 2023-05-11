using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Blinking : MonoBehaviour
{
    public string charactertype;
    public int selection = 0;

    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public Sprite blinkingSprite;
    public Sprite originalSprite;
    private bool randomer = false;
    private float nextTime;
    public void Start(){
        timer();
    }

    public void Update(){
        if(randomer){
            timer();
            blink();
            randomer = false;
        }
        if(Time.time > nextTime && !randomer){
            randomer = true;
        }
        
    }

    private void timer(){
        float timer = Random.Range(30.0f, 60.0f);
        nextTime = Time.time + timer;
        randomer = true;
    }

    private void blink(){
        spriteRenderer.sprite = blinkingSprite;
        Invoke("open", 0.2f);
    }

    private void open(){
        spriteRenderer.sprite = originalSprite;
    }

    public void setCurrentText(int choice){
        selection = choice;
    }

}
