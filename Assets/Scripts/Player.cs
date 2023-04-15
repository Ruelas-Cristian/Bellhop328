using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    //private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    // Start is called before the first frame update

    // [Header("Interactable Objects")]
    // [SerializeField] GameObject dresserUI;
    // private bool dreUITest;
    // private bool canMove = true;

    private bool interactableEnabled = false;
    private GameObject itemObject;

    void Start()
    {
        // dresserUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if(canMove)
            horizontal = Input.GetAxis("Horizontal");
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
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y );
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

    // private void OnTriggerStay2D(Collider2D other) {
    //     if(other.CompareTag("Dresser")){
    //         if(Input.GetKeyDown(KeyCode.E)){
    //             if(!dreUITest) {
    //                 dresserUI.SetActive(true);
    //                 dreUITest = true;
    //                 canMove = false;
    //             } else {
    //                 dresserUI.SetActive(false);
    //                 dreUITest = false;
    //                 canMove = true;
    //             }
    //         }
    //     }
    // }

    private void OnTriggerExit2D(Collider2D other){
        itemObject = null;
        interactableEnabled = false;
    }

}
