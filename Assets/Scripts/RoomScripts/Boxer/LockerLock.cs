using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockerLock : MonoBehaviour
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
        if(s == "2020"){
            locker.GetComponent<Locker>().open();
            lockerlock.GetComponent<LockerLockFinder>().check();
        }
    }
}
