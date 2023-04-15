using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickInput : MonoBehaviour
{
    private bool interactableEnabled = false;

    void Update(){
        /*if(interactableEnabled){
            interactableEnabled = !interactableEnabled;
        }*/
    }

    private void OnMouseDown(){
        print("Enabled");
        if(this.TryGetComponent(out Interactable interactable) && !interactableEnabled){
                interactable.enable();
                interactableEnabled = true;
            } else if(this.TryGetComponent(out Interactable interactableout) && interactableEnabled){
                interactableout.disable();
                interactableEnabled = false;
            }
    }

}
