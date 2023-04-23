using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class toggleInteractUI : MonoBehaviour {
    [Header("UI Elements")]
    [SerializeField] GameObject[] _UI;              //Array of ui game objects
    [SerializeField] GameObject interactUI;

    [Header("Input Field")]
    [SerializeField] InputField iField;
    private string _password;
    private bool checkInput;

    static public bool checkVenPass = false;
    static public bool VenkeyCheck = false;
    private Collider2D _otherColider;
    private bool _playerOver = false;
    private bool draUITest = false;
    private bool clockCheck = false;

    void Start() {
        for (int i = 0; i < _UI.Length; i++)
            _UI[i].SetActive(false);

        interactUI.SetActive(false);
    }

    void Update() {
        _password = iField.text;

        if (_password == "doom" || _password == "Doom" || _password == "DOOM")
            checkInput = true;
        else
            checkInput = false;

        //interaction
        if (Input.GetKeyDown(KeyCode.E)) {
            if (_playerOver && !draUITest) {
                Player.canMove = false;
                draUITest = true;
            } else if (_playerOver && draUITest) {
                Player.canMove = true;
                draUITest = false;
            }
        }
    }
    void FixedUpdate() { 
        //This will test if the player is over the object
        //and if the player pressed 'E' while over this object
        if (_playerOver && draUITest) {
            if (_otherColider.CompareTag("Drawer"))
                _UI[0].SetActive(true);                 //Turn on the Drawer UI object
            else if (_otherColider.CompareTag("Board"))
                _UI[1].SetActive(true);                 //Turn on the Notice Board UI object
            else if (_otherColider.CompareTag("FileCabinet")) {
                _UI[2].SetActive(true);
                if (checkInput)
                    _UI[3].SetActive(true);
            } else if (_otherColider.CompareTag("Vending")) {
                _UI[4].SetActive(true);
                _UI[5].SetActive(false);
                VenkeyCheck = true;
                if (checkVenPass)
                    _UI[5].SetActive(true);
            } else if (_otherColider.CompareTag("DeskDrawer") && checkVenPass) {
                _UI[6].SetActive(true);
                clockCheck = true;
            } else if (_otherColider.CompareTag("Clock") && clockCheck)
                _UI[7].SetActive(true);
        } else if (_playerOver && !draUITest) {
            for (int i = 0; i < _UI.Length; i++) 
                _UI[i].SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Drawer") || other.CompareTag("Board") || other.CompareTag("FileCabinet") || other.CompareTag("Vending")
            || other.CompareTag("DeskDrawer") || other.CompareTag("Clock")) { 
            Debug.Log("On Object");
            _otherColider = other;
            interactUI.SetActive(true);
            _playerOver = true; // truns the playerover flag true for the player script
        } 
    }

    //When the player leaves this objects collider, it will trun off both the flag and the interaction UI
    private void OnTriggerExit2D(Collider2D other) {
        interactUI.SetActive(false);
        _playerOver = false;
        _otherColider = null;
        VenkeyCheck = false;
    }
}
