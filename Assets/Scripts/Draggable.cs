using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void enable(){
        this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
        this.GetComponent<BoxCollider2D>().enabled = true;
        
    }

    public void disable(){
        this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 140);
        this.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
