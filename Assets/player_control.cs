using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{

    public Rigidbody2D playerRB;
    public CapsuleCollider2D playerCollisionStanding;
    public CapsuleCollider2D playerCollisionSliding;
    public float jumpForce;

    [SerializeField] private Transform feetposition;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float JumpTime = 0.25f;
   
    private bool isGrounded = true;
    private bool isJumping = false;
    private float jumpTimer;
    bool slide;
    bool isSliding;

    // Update is called once per frame
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetposition.position, groundDistance, groundLayer);

     if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            playerRB.velocity = Vector2.up * jumpForce;
            isGrounded = false;
            isJumping = true;
        }
        if (isJumping == true && Input.GetButton("Jump"))
        {
            if(jumpTimer < JumpTime)
            {
                playerRB.velocity = Vector2.up * jumpForce;

                jumpTimer += Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        
        if(Input.GetButton("Jump"))
        {
            isJumping = false;
            jumpTimer = 0f;

            // this changes the player's collider size. 
            // look up platformer duck tutorial
            //playerCollision.size = new Vector2(1, 0.5f);
        }
        if (Input.GetButtonDown("slide"))
            slide = true;
        else if (Input.GetButtonDown("slide"))
            slide = false;

        if (isGrounded && isSliding)
        {
          //  playerCollisionStanding;
        }
// something to disable the stand capsule's collision
           
    }
}
