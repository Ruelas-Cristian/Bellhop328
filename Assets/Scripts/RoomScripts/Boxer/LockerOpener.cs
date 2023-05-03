using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerOpener : MonoBehaviour
{
    public GameObject itemObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Money")){
            itemObject.GetComponent<Locker>().open();
        }
    }
}
