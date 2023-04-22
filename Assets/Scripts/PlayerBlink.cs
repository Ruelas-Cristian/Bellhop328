using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlink : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite blinkingSprite;
    public Sprite originalSprite;
    private bool randomer = false;
    private float nextTime;

    // Start is called before the first frame update
    void Start()
    {
        timer();
    }

    // Update is called once per frame
    void Update()
    {
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
        float timer = Random.Range(1.0f, 10.0f);
        nextTime = Time.time + timer;
        randomer = true;

    }

    private void blink(){
        spriteRenderer.sprite = blinkingSprite;
        Invoke("open", 0.5f);
    }

    private void open(){
        spriteRenderer.sprite = originalSprite;
    }
}
