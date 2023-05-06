using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCook : MonoBehaviour
{
    public GameObject pan;
    public GameObject chef;
    public GameObject key;
    private bool setspawn = false;

    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Pan")){
        if(pan.GetComponent<CookingPan>().checkifcorrect() && !setspawn){
            Debug.Log(pan.GetComponent<CookingPan>().count);
            chef.GetComponent<TalkingScript>().setCurrentText(5);
            chef.GetComponent<TalkingScript>().enable();
            key.SetActive(true);
            setspawn = true;
        } else if(!setspawn) {
            chef.GetComponent<TalkingScript>().setCurrentText(4);
            chef.GetComponent<TalkingScript>().enable();
        }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
