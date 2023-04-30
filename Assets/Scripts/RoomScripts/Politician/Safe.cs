using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour, Interactable, ActionClasser
{

    public GameObject mirror;
    public int num;
    public GameObject painting;
    public Sprite safe;

    void Start()
    {
        mirror.SetActive(false);
    }

    public void enable(){

    }

    public void disable(){

    }

    public void Do(){
        unhide();
    }

    private void unhide(){
        painting.GetComponent<Rigidbody2D>().simulated = true;
    }

    private bool checkPassword(int guess){
        if(guess == num){
            return true;
        }   else {
            return false;
        }
    }

    public void open(){
        this.GetComponent<SpriteRenderer>().sprite = safe;
        mirror.SetActive(true);
    }

    void Update()
    {
        
    }
}
