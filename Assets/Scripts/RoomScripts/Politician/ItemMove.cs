using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemMove : MonoBehaviour, Interactable
{
    public Sprite picture;
    public GameObject viewport;
    public GameObject port = null;

    // Start is called before the first frame update
    void Start()
    {
        viewport.SetActive(false);
    }

    public void enable(){
        viewport.SetActive(true);
        viewport.GetComponent<Image>().sprite = picture;
        if(port.GetComponent<OpenJourn>()){
                port.GetComponent<OpenJourn>().Counter();
            }
        Invoke("stop", 2.0f);
    }

    public void disable(){
        viewport.SetActive(true);
        viewport.GetComponent<Image>().sprite = picture;
        if(port.GetComponent<OpenJourn>()){
                port.GetComponent<OpenJourn>().Counter();
            }
        Invoke("stop", 2.0f);
    }

    // Update is called once per frame
    private void stop(){
        viewport.SetActive(false);
    }

}
