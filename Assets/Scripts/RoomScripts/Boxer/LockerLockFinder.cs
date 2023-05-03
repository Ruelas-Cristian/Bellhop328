using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockerLockFinder : MonoBehaviour
{
    public GameObject lockerlock;
    private bool checker = false;

    // Start is called before the first frame update
    void Start()
    {
        lockerlock.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Player") && !checker){
        lockerlock.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player") && !checker){
        lockerlock.SetActive(false);
        }
    }

    public void check(){
        checker = true;
        lockerlock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
