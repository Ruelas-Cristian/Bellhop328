using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour, Interactable, ActionClasser
{

    public GameObject self;
    public int num;
    public GameObject painting;

    void Start()
    {
        self.SetActive(false);
    }

    public void enable(){

    }

    public void disable(){

    }

    public void Do(){
        unhide();
    }

    private void unhide(){
        self.SetActive(true);
        painting.GetComponent<Rigidbody2D>().simulated = true;
    }

    private bool checkPassword(int guess){
        if(guess == num){
            return true;
        }   else {
            return false;
        }
    }

    private void open(){

    }

    void Update()
    {
        
    }
}
