using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChecker : MonoBehaviour
{
    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject Safe;

    public void check(){
        if(D1.GetComponent<NumCheck>().answerQ() && D2.GetComponent<NumCheck>().answerQ() && D3.GetComponent<NumCheck>().answerQ() && D4.GetComponent<NumCheck>().answerQ()){
            Safe.GetComponent<Cabinet>().Open();
        }
    }
}
