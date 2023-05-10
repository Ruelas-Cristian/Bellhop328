using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorJournalist : MonoBehaviour, Interactable
{
    public string Level;
    public string Level2;
    public string doorType;
    [SerializeField] 
    private FloatSO mirrors; 

    public void enable(){
        if(mirrors.Value >= 3){
            Debug.Log("Loading level");
            PlayerPrefs.SetString("doorType", doorType);
            SceneManager.LoadScene(Level2);
        } else {
            Debug.Log("Loading level");
            PlayerPrefs.SetString("doorType", doorType);
            SceneManager.LoadScene(Level);
        }
    }

    public void disable(){

    }
}
