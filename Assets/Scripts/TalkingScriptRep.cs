using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkingScriptRep : MonoBehaviour, Interactable
{
    [SerializeField] TextMeshProUGUI TalkingText;
    public string charactertype;
    public float selection = 0;

    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public Sprite blinkingSprite;
    public Sprite originalSprite;
    private bool randomer = false;
    private float nextTime;
    [SerializeField]
    private FloatSO talked;
    [SerializeField]
    private FloatSO unlocked;

    public void Start(){
        timer();
        selection = talked.Value;
    }

    public void Update(){
        if(randomer){
            timer();
            blink();
            randomer = false;
        }
        if(Time.time > nextTime && !randomer){
            randomer = true;
        }
        
    }

    private void timer(){
        float timer = Random.Range(1.0f, 10.0f);
        nextTime = Time.time + timer;
        randomer = true;
    }

    private void blink(){
        spriteRenderer.sprite = blinkingSprite;
        Invoke("open", 0.5f);
    }

    private void open(){
        spriteRenderer.sprite = originalSprite;
    }

    public void enable(){
        selection = talked.Value;
        Debug.Log(talked.Value);
        TalkingText.text = Phrases();

        Invoke("stoptalking", 5.0f);
    }

    public void disable(){
        TalkingText.text = Phrases();
        Invoke("stoptalking", 5.0f);
    }

    public void stoptalking(){
        TalkingText.text = "";
    }

    public void setCurrentText(int choice){
        selection = choice;
    }

    public string Phrases(){
        Debug.Log("Running");
        if(charactertype == "receptionist"){
            switch(selection){
            case 0:
                return "\"Hey! You got here just in time; A Guest reported a sound coming from the Journalist's room on the executive floor, do you mind checking it out. But first you need to collect the key from the office.\"";
            case 1:
                unlocked.Value = 1;
                return "\"I've heard that the Journalist has been shot, the police are on their way! Oh and here is you master key, please investigate each of the guests rooms then head back to the Journalist's room!\"";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "";
            case 5:
                return "";
            default:
                break;
        }
        }
        if(charactertype == "chef"){
            switch(selection){
            case 0:
                return "";
            case 1:
                return "\"Hey donkey make me something to eat and I might give you the Key to the wine cabinet.\"";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "\"You call this linguine?! My grandmother could shit something more edible. Put this in the sink and make it again\"";
            case 5:
                return "\"Not bad, I’d feed this to my dog.\"";
            default:
                break;
        }
        }
        if(charactertype == "politician"){
            switch(selection){
            case 0:
                return "";
            case 1:
                return "";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "";
            case 5:
                return "";
            default:
                break;
        }
        if(charactertype == "boxer"){
            switch(selection){
            case 0:
                return "";
            case 1:
                return "";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "";
            case 5:
                return "";
            default:
                break;
        }
        }
        if(charactertype == "billionare"){
            switch(selection){
            case 0:
                return "";
            case 1:
                return "";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "";
            case 5:
                return "";
            default:
                break;
        }
        }
        if(charactertype == "police"){
            switch(selection){
            case 0:
                return "";
            case 1:
                return "";
            case 2:
                return "";
            case 3:
                return "";
            case 4:
                return "";
            case 5:
                return "";
            default:
                break;
        }
        }
        }
        return "";
    }
}
