using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public Sprite oneSet;
    public Sprite original;
    public Sprite twoOfSet;

    public void walk(){
        this.GetComponent<SpriteRenderer>().sprite = oneSet;
        Invoke("Return", 0.25f);
    }

    public void Return(){
        this.GetComponent<SpriteRenderer>().sprite = twoOfSet;
        Invoke("walk", 0.25f);
    }

    public void STOPwalking(){
        CancelInvoke();
        this.GetComponent<SpriteRenderer>().sprite = original;
    }

}
