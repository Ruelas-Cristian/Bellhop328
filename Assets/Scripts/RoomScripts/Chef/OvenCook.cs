using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenCook : MonoBehaviour, Interactable
{
    public GameObject pan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void enable(){
        pan.GetComponent<CookingPan>().cook();
    }

    public void disable(){
        pan.GetComponent<CookingPan>().cook();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
