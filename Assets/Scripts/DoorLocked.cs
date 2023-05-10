using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLocked : MonoBehaviour, Interactable
{
    public string Level;
    public string doorType;
    [SerializeField]
    private FloatSO locks;

    public void enable(){
        if(getUnlock()){
            Debug.Log("Loading level");
            PlayerPrefs.SetString("doorType", doorType);
            SceneManager.LoadScene(Level);
        }
    }

    private bool getUnlock(){
        if(locks.Value >= 1){
            return true;
        }
        return false;
    }

    public void disable(){

    }
}
