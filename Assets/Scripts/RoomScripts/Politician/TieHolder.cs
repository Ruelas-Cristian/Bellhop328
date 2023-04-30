using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieHolder : MonoBehaviour
{
    public int numChecker;
    private GameObject itemObject;
    private bool pass = false;

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Tie")){
            itemObject = other.gameObject;
            if(itemObject.GetComponent<Tie>()){
                if(itemObject.GetComponent<Tie>().tied() == numChecker){
                    pass = true;
                } else {
                    pass = false;
                }
            }
        }
    }

    public bool passed(){
        return pass;
    }
}
