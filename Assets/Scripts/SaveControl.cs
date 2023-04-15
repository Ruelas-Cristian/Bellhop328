using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveControl : MonoBehaviour
{
    public bool EnableSaver = false;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Draggable>() && EnableSaver){
            Destroy(other.gameObject);
        }
    }
}
