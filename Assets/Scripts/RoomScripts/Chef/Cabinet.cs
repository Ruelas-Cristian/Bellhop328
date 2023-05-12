using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cabinet : MonoBehaviour, Interactable
{
    [SerializeField] TextMeshProUGUI TalkingText;
    private bool key = false;
    private bool open = false;
    private GameObject itemObject;
    public GameObject viewport;
    public GameObject book;
    public Sprite paper;
    public Sprite opened;

    void Start()
    {
        viewport.SetActive(false);
        book.SetActive(false);
        //book.SetActive(false);
    }

    void Update()
    {
        
    }

    public void enable(){
        if(key){
            viewport.GetComponent<Image>().sprite = paper;
            viewport.SetActive(true);
            Invoke("stop", 5.0f);
            open = true;
            book.GetComponent<Rigidbody2D>().simulated = true;
            //book.SetActive(true);
        }
    }

    public void disable(){
        if(key){
            viewport.GetComponent<Image>().sprite = paper;
            viewport.SetActive(true);
            Invoke("stop", 5.0f);
            open = true;
        }
    }

    public void Open(){
            key = true;
            this.GetComponent<SpriteRenderer>().sprite = opened;
            book.SetActive(true);
            TalkingText.text = "Press E to view Image";
            Invoke("stop", 2.0f);
    }

    private void stop(){
        viewport.SetActive(false);
        TalkingText.text = null;
    }

}
