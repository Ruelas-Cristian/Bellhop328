using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoors : MonoBehaviour
{
    [SerializeField]
    private FloatSO locks;

    private void unlockDoors(){
        locks.Value += 1;
        Debug.Log(locks.Value);
    }
}
