using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyed : MonoBehaviour
{
    [SerializeField]
    public AudioSource audioSource;
    private FloatSO unlockJourn;

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            unlockJourn.Value = 1;
            audioSource.Play();
            Debug.Log(unlockJourn.Value);
        };
    }
}
