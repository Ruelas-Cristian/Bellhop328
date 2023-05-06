using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockerLock1 : MonoBehaviour
{
    public GameObject locker;
    public GameObject lockerlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s){
        //print(s);
        if(s == "210"){
            locker.GetComponent<Locker>().open();
            lockerlock.GetComponent<LockerLockFinder>().check();
        }
    }
}
