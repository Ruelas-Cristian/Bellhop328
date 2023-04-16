using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drawer_Script : MonoBehaviour {
    [Header("UI Elements")]
    [SerializeField] GameObject dresserUI;
    [SerializeField] GameObject interactUI;
    static public bool _playerOver = false;
    static public bool draUITest;

    void Start() { 
        dresserUI.SetActive(false);
        interactUI.SetActive(false);
    }

    void FixedUpdate() {
        //This will test if the player is over the object
        //and if the player pressed 'E' while over this object
        if (_playerOver && draUITest) {
            dresserUI.SetActive(true);      //This UI will represet the inside of the drawer when made
        } else if (_playerOver && !draUITest) {
            dresserUI.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            interactUI.SetActive(true);
            _playerOver = true; // truns the playerover flag true for the player script
        } 
    }

    //When the player leaves this objects collider, it will trun off both the flag and the interaction UI
    private void OnTriggerExit2D(Collider2D other) {
        interactUI.SetActive(false);
        _playerOver = false;
    }
}
