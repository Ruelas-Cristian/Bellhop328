using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character Physics")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [Header("KeyCode - for key input puzzle")]
    [SerializeField] KeyCode[] KeyCodeSeriesVending = new KeyCode[] { KeyCode.UpArrow, KeyCode.LeftArrow, KeyCode.UpArrow, KeyCode.UpArrow };
    [SerializeField] float DelayBeforeReset = 86400;
    private int keyCodeIndex = 0;
    private float lastKeyPressTime;

    static public bool canMove = true;
    private float horizontal;
    private float speed = 8f;
    //private float jumpingPower = 16f;
    private bool isFacingRight = true;
    private bool interactableEnabled = false;
    private GameObject itemObject;

   
    // Update is called once per frame
    void Update()
    {
        if (canMove)
            horizontal = Input.GetAxis("Horizontal");
        else
            horizontal = 0f;    //turns hoizontal movement to zero so player doesn't float away

        //Commented out code below is for jumping
        /*if(Input.GetButtonDown("Jump") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.1f);
        }*/

        Flip();

        //code for interactions
        if(itemObject && Input.GetKeyDown(KeyCode.E)){
            if(itemObject.TryGetComponent(out Interactable interactable) && !interactableEnabled){
                interactable.enable();
                interactableEnabled = true;
            } else if(itemObject.TryGetComponent(out Interactable interactableout) && interactableEnabled){
                interactableout.disable();
                interactableEnabled = false;
            }
        }
        if(!itemObject && interactableEnabled){
            interactableEnabled = !interactableEnabled;
        }


    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (toggleInteractUI.VenkeyCheck)
            KeyCodeCheck();
    }

    private void KeyCodeCheck() {
        //if the KeyCode is empty it will return
        if (KeyCodeSeriesVending.Length == 0)
            return;

        if( Time.time - lastKeyPressTime > DelayBeforeReset) {
            Debug.Log("Ran out of time");
            keyCodeIndex = 0;
            toggleInteractUI.checkVenPass = false;
        }

        if (Input.GetKey(KeyCodeSeriesVending[keyCodeIndex])) {
            lastKeyPressTime = Time.time;
            keyCodeIndex++;

            if(keyCodeIndex >= KeyCodeSeriesVending.Length) {
                Debug.Log("Correct Key");
                toggleInteractUI.checkVenPass = true;

                keyCodeIndex = 0;
            }
        } else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("Wrong Key Press... Start over");
            keyCodeIndex = 0;
            toggleInteractUI.checkVenPass = false;
        }

    }


    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f){
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }


    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On Object");
        if(other.CompareTag("Interactable")){
            itemObject = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        itemObject = null;
        interactableEnabled = false;
    }

}
