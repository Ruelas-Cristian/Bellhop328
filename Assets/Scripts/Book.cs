using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Book : MonoBehaviour, Interactable
{
    [SerializeField] TextMeshProUGUI BookText;
    public string Entry;

    // Start is called before the first frame update
    public void enable(){
        BookText.text = Entry;
    }

    public void disable(){
        BookText.text = "";
    }
}
