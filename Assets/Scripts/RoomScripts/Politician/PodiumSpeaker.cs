using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PodiumSpeaker : MonoBehaviour, Interactable, ActionClasser
{
    [SerializeField] TextMeshProUGUI TalkingText;
    private bool isenabled = false;

    // Start is called before the first frame update
    void Start()
    {
        TalkingText.text = "";
    }

    public void Do(){
        isenabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enable(){
        if(isenabled){
            play();
        }
    }

    public void disable(){
        if(isenabled){
            play();
        }
    }

    private void play(){
        TalkingText.text = "\"Today we perpare the 77\"";
        Invoke("StopthePlaying", 2.0f);
    }

    private void StopthePlaying(){
        TalkingText.text = "";
    }

}
