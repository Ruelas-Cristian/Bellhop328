using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickInputToturial : MonoBehaviour
{
    public GameObject Ui;


    void OnMouseDown(){
        Ui.GetComponent<toggleInteractUI>().enable(this.GetComponent<Collider2D>());
    }

}
