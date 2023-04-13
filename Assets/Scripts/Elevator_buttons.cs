using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator_buttons : MonoBehaviour{ 
    public void changeScene(string room) {
        SceneManager.LoadScene(room);
    }
}

