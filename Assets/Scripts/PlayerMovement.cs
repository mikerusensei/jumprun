using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jump = 14;
    public LayerMask groundLayer;
    public Rigidbody2D playerRb;
    public Animator playerAnim;
    public Transform groundCheck;
    

    //PlayerControl playerControl;
    //private float direction = 0;
    private int numberofJumps = 0;
    private bool isFacingRight;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        var jump = Input.GetButtonDown("Jump");

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        playerAnim.SetBool("IsJumping", isGrounded);

        if (!PlayerManager.isGameOver && !PlayerManager.isWinner)
        {

            playerRb.velocity = new Vector2(move * speed, playerRb.velocity.y);


            if (isFacingRight && move < 0 || !isFacingRight && move > 0)
            {
                Flip();
            }


            if (jump)
            {
                Jump();
            }

            if (move != 0)
            {
                playerAnim.SetBool("IsRunning", true);
            }
            else
            {
                playerAnim.SetBool("IsRunning", false);
            }
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }

    private void Jump()
    {
        if (isGrounded)
        {
            numberofJumps = 0;
            playerRb.velocity = new Vector2(playerRb.velocity.x, jump);
            numberofJumps++;
        }
        else
        {
            if (numberofJumps == 1)
            {
                playerRb.velocity = new Vector2(playerRb.velocity.x, jump);
                numberofJumps++;
            }
        }

    }
}
