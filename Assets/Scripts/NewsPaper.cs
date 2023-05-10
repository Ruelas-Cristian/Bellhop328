using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsPaper : MonoBehaviour
{
    [SerializeField]
    private FloatSO talked;
    public void set(){
        talked.Value = 1;
        Debug.Log(talked.Value);
    }
}
