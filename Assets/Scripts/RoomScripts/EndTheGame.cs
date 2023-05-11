using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTheGame : MonoBehaviour, Interactable
{
    public string Level;

    public void enable(){
        SceneManager.LoadScene(Level);
    }

    public void disable(){

    }
}
