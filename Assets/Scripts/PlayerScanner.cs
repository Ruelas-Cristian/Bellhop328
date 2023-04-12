using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScanner : MonoBehaviour
{
    //The code below is for checking if the player is on the collider of the interactable game object
    public void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Interactable"))
            {
                if(Input.GetKeyDown(KeyCode.E)){
                   other.GetComponent<Interactable>().enable();
                }
        }
    }
}
