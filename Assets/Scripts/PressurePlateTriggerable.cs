using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateTriggerable : MonoBehaviour
{
    public string ComparibleTag = "";
    public Transform snapper;
    public GameObject self;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag(ComparibleTag)){
            if(self.TryGetComponent(out ActionClasser action)){
                action.Do();
            }

        }
    }

    
}
