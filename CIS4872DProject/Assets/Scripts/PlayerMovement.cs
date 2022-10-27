using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    public float speed = 8f;
    public float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    //public float movementSpeed; // movement speed
    //public Rigidbody2D rb;  //forces to player 

    //public float jumpForce = 10f;
    //public int extraJump = 0;
    //public Transform feet;
    //public LayerMask groundLayers;


    //private float mx; //movement on the x-axis 
    //private bool doubleJumpAllowed;


    //private bool Walljumping;
    //private float touchingLeftorRight = 1;

    //// public Animator anim;

    //private void Update()
    //{
    //    mx = Input.GetAxisRaw("Horizontal");
    //    if (Input.GetButton("Jump") && IsGrounded())
    //    {
    //        Jump(); //calls the jump function  
    //        doubleJumpAllowed = true;
    //    }

    //    else if (Input.GetButton("Jump") && doubleJumpAllowed) //will allow the player to double jump
    //    {
    //        Jump();
    //        doubleJumpAllowed = false;
    //    }
    //    if (Walljumping == true)
    //    {
    //        rb.velocity = new Vector2(movementSpeed * touchingLeftorRight, jumpForce);

    //    }

    //}
    //private void FixedUpdate()
    //{
    //    //
    //    Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
    //    rb.velocity = movement;



    //}
    //void SetJumpingToFalse()
    //{
    //    Walljumping = false;
    //}

    //void Jump()
    //{
    //    Vector2 movement = new Vector2(rb.velocity.x, jumpForce); //this will allows us to jump
    //    rb.velocity = movement;



    //}
    //public bool IsGrounded()
    //{
    //    Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);


    //    if (groundCheck != null)
    //    {

    //        return true;
    //    }
    //    return false;
    //}
}
