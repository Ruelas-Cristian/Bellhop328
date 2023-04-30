using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour, Interactable
{
    public GameObject tie1;
    public GameObject tie2;
    public GameObject tie3;
    public GameObject tie4;
    public GameObject tie5;
    public Sprite open;
    public Sprite close;

    void Start(){
        tie1.SetActive(false);
        tie2.SetActive(false);
        tie3.SetActive(false);
        tie4.SetActive(false);
        tie5.SetActive(false);
    }

    // Start is called before the first frame update
    public void enable(){
        print("opening");
        this.GetComponent<SpriteRenderer>().sprite = open;
        tie1.SetActive(true);
        tie2.SetActive(true);
        tie3.SetActive(true);
        tie4.SetActive(true);
        tie5.SetActive(true);
    }

    public void disable(){
        print("closing");
        this.GetComponent<SpriteRenderer>().sprite = close;
        tie1.SetActive(false);
        tie2.SetActive(false);
        tie3.SetActive(false);
        tie4.SetActive(false);
        tie5.SetActive(false);
    }

}
