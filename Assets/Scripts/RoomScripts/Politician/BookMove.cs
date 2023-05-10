using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BookMove : MonoBehaviour, Interactable
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
        if (this.GetComponent<NewsPaper>()){
            this.GetComponent<NewsPaper>().set();
        }
        Invoke("stop", 2.0f);
    }

    public void disable(){
        viewport.SetActive(true);
        viewport.GetComponent<Image>().sprite = picture;
        Invoke("stop", 2.0f);
    }

    // Update is called once per frame
    private void stop(){
        viewport.SetActive(false);
    }

}
