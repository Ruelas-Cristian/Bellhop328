using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorPieces : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Destroy(this.gameObject);
        }
    }
}
