using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuzzleMove : MonoBehaviour, Interactable
{
    public Sprite picture;
    public GameObject viewport;

    // Start is called before the first frame update
    void Start()
    {
        viewport.SetActive(false);
    }

    public void enable(){
        viewport.SetActive(true);
        viewport.GetComponent<Image>().sprite = picture;
        //Invoke("stop", 2.0f);
    }

    public void disable(){
        stop();
    }

    // Update is called once per frame
    private void stop(){
        viewport.SetActive(false);
    }

}
