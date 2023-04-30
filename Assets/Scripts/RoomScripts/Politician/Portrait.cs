using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portrait : MonoBehaviour, Interactable
{
    public GameObject painting;
    private bool enabled1 = false;

    public void enable(){
        Debug.Log("Enabling");
        /*if(!enabled){
            painting.GetComponent<Rigidbody2D>().simulated = true;
            enabled1 = true;
        }*/
    }

    public void disable(){
        Debug.Log("Enabling");
        /*if(!enabled){
            painting.GetComponent<Rigidbody2D>().simulated = true;
            enabled1 = true;
        }*/
    }
}
