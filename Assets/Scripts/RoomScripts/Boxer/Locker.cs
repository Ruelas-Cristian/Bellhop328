using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Locker : MonoBehaviour
{
    public Sprite opened;
    [SerializeField] TextMeshProUGUI TalkingText;
    private bool key = false;
    private GameObject itemObject;
    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        item.SetActive(false);
    }

    void Update()
    {
        
    }
        private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Money")){
            stop();
            itemObject = other.gameObject;
            open();
            Invoke("stop", 2.0f);
            Destroy(itemObject);
        } else if(other.CompareTag("Player") && !key){
            TalkingText.text = "\"Looks like I need a Key\"";
            Invoke("stop", 2.0f);
        }
    }

    public void open(){
        if(!key){
            this.GetComponent<SpriteRenderer>().sprite = opened;
            key = true;
            item.SetActive(true);
            Destroy(itemObject);
        }
    }

    private void stop(){
        TalkingText.text = null;
    }
}
