using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioData;

    public void play(){
        audioData.Play();
    }
}
