using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumCheck : MonoBehaviour
{
    private bool check = false;
    public GameObject cabinet;
    public int number = 0;

    public bool answerQ(){
        return check;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Num>()){
            if(other.GetComponent<Num>().numberer() == number){
                check = true;
                cabinet.GetComponent<DirectionChecker>().check();
            } else {
                check = false;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.GetComponent<Num>()){
            check = false;
        }
    }
}
