using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJourn : MonoBehaviour
{
    public GameObject locker;
    private int count = 0;
    private bool check = false;

    void Update(){
        if(count >= 2 && !check){
            openLocker();
            check = true;
        }
    }

    public void Counter(){
        count = count + 1;
    }

    private void openLocker(){
        locker.GetComponent<Locker>().open();
    }
}
