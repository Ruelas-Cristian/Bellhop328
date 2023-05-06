using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<CookingPan>()){
            other.GetComponent<CookingPan>().clean();
        }
    }
}
