using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieChecker : MonoBehaviour
{
    public GameObject tieHolder1;
    public GameObject tieHolder2;
    public GameObject tieHolder3;
    public GameObject tieHolder4;
    public GameObject tieHolder5;
    public Transform snapper;
    public GameObject key;
    private bool used = false;

    void Start(){
        key.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(tieHolder1.GetComponent<TieHolder>().passed() && tieHolder2.GetComponent<TieHolder>().passed() && tieHolder3.GetComponent<TieHolder>().passed() && tieHolder4.GetComponent<TieHolder>().passed() && tieHolder5.GetComponent<TieHolder>().passed() && !used){
            key.SetActive(true);
            used = true;
        }
    }
}
