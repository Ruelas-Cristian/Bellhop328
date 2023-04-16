using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator_buttons : MonoBehaviour{
    public string doorType;
    public void changeScene(string room) {
        PlayerPrefs.SetString("doorType", doorType);
        SceneManager.LoadScene(room);
    }
}

