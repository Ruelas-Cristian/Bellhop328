using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, Interactable
{
    public string Level;
    public string doorType;

    public void enable(){
        Debug.Log("Loading level");
        PlayerPrefs.SetString("doorType", doorType);
        SceneManager.LoadScene(Level);
    }

    public void disable(){

    }
}
