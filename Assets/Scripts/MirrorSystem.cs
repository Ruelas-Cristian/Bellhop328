using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorSystem : MonoBehaviour
{
    string mirrors = "Mirrors";
    public int CurrentMirrorsCollected { get; set;}

    // Start is called before the first frame update
    private void Awake(){
        CurrentMirrorsCollected = PlayerPrefs.GetInt(mirrors);
    }

    // Update is called once per frame

    public void SetScore(int score){
        PlayerPrefs.SetInt(mirrors, score);
    }
}
