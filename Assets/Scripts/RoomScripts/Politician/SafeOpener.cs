using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeOpener : MonoBehaviour
{
    public GameObject safe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Book")){
            safe.GetComponent<Safe>().open();
        }
        /*Debug.Log("On Object");
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
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
