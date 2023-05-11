using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingInteractible : MonoBehaviour, Interactable
{
    public string SceneName;

    public void enable(){
        Invoke("disable", 5.0f);
    }

    public void disable(){
        SceneManager.LoadScene(SceneName);
    }
}
