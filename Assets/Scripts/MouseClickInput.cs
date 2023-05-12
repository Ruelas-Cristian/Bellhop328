using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickInput : MonoBehaviour
{
    void OnMouseDown(){
        Debug.Log("Clicked On!");
        if(this.TryGetComponent(out Interactable interactable)){
                interactable.enable();
            }
    }

}
