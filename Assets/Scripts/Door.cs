using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, Interactable
{
    public string Level;

    public void enable(){
        Debug.Log("Loading level");
        SceneManager.LoadScene(Level);
    }

    public void disable(){

    }
}
