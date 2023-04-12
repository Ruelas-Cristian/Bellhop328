using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleBaseClass : MonoBehaviour, Interactable
{
    //this is where we'll add code related to what the object does when interacted with, etc.
        private Color defaultColor;

        public void Start(){
            defaultColor = this.GetComponent<SpriteRenderer>().color;
        }

        public void enable(){
            Debug.Log("Using Object");
            print("Enabled object");
            this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
    }
        public void disable(){
            Debug.Log("Using Object");
            print("Disabled object");
            this.GetComponent<SpriteRenderer>().color = defaultColor;
        }
}