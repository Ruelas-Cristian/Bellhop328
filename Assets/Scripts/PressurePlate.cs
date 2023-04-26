using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject platfrom;
    public GameObject platfromLight;
    public GameObject objectoftypesafe;
    private bool moveBack = false;
    private bool UpBlock = false;
    private bool DownBlock = false;




    private bool movingUp = false;
    private bool movingDown = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Top")){
            UpBlock = true;
        } else if(other.CompareTag("Bottom")){
            DownBlock = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Top")){
            UpBlock = false;
        } else if(other.CompareTag("Bottom")){
            DownBlock = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision){
        if(collision.transform.GetComponent<Draggable>() && !collision.transform.CompareTag("LeveR") && !UpBlock){
            if(!moveBack){
                if(objectoftypesafe.GetComponent<Safe>()){
                    objectoftypesafe.GetComponent<Safe>().Do();
                }
            }
            moveBack = true;
            platfrom.transform.Translate(0, -0.01f, 0);
        } else if(collision.transform.CompareTag("LeveR") && !DownBlock){
            platfrom.transform.Translate(0, 0.01f, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.GetComponent<Draggable>() && !collision.transform.CompareTag("LeveR") && !UpBlock){
            collision.transform.parent = transform;
            platfromLight.GetComponent<SpriteRenderer>().color = Color.red;
        } else if(collision.transform.CompareTag("LeveR") && !DownBlock){
            collision.transform.parent = transform;
            platfromLight.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void OnCollisionExit2D(Collision2D collision){
        if(collision.transform.GetComponent<Draggable>())
        {
            moveBack = true;
            collision.transform.parent = null;
            platfromLight.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    /*private void Update(){
        if(moveBack){
            if (transform.position.y > originalPos.y){
                transform.Translate(0, 0.01f, 0);
            } else {
                moveBack = false;
            }
        }
    }*/
}
