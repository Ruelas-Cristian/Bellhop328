using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private FloatSO mirrors;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            mirrors.Value = mirrors.Value + 1;
            Debug.Log(mirrors.Value);
            Destroy(this.gameObject);
        }
    }
}
