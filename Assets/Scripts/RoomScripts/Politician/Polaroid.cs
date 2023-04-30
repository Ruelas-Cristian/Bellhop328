using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Polaroid : MonoBehaviour, Interactable
{
    public Sprite picture;
    public GameObject viewport;

    public void enable(){
            viewport.GetComponent<Image>().sprite = picture;
            viewport.SetActive(true);
            Invoke("hidepicture", 5.0f);
    }

    public void disable(){
        viewport.GetComponent<Image>().sprite = picture;
        viewport.SetActive(true);
        Invoke("hidepicture", 5.0f);
    }

    void Start()
    {
        viewport.SetActive(false);
    }

    private void hidepicture(){
        viewport.SetActive(false);
    }

}
