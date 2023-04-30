using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BriefCase : MonoBehaviour, Interactable
{
    [SerializeField] TextMeshProUGUI TalkingText;
    private bool key = false;
    private bool open = false;
    private GameObject itemObject;
    public GameObject viewport;
    public Sprite paper;
    public Sprite opened;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void enable(){
        if(key && !open){
            viewport.GetComponent<Image>().sprite = paper;
            viewport.SetActive(true);
            Invoke("stop", 5.0f);
            open = true;
        } else if(open){
            stop();
            open = false;
        }
    }

    public void disable(){
        if(key && !open){
            viewport.GetComponent<Image>().sprite = paper;
            viewport.SetActive(true);
            Invoke("stop", 5.0f);
            open = true;
        } else if(open){
            stop();
            open = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Key")){
            itemObject = other.gameObject;
            key = true;
            this.GetComponent<SpriteRenderer>().sprite = opened;
            TalkingText.text = "Press E to view Image";
            Invoke("stop", 2.0f);
            Destroy(itemObject);
        } else if(other.CompareTag("Player") && !key){
            TalkingText.text = "\"Looks like I need a Key\"";
            Invoke("stop", 2.0f);
        }
    }

    private void stop(){
        viewport.SetActive(false);
        TalkingText.text = null;
    }

}
