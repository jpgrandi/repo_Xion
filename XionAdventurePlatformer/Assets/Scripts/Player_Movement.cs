using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
    [Header ("Speeds")]
    public float moveSpeed;
    public float jumpSpeed;

    public bool isRightFacing;

    public float moveDir;
    private Rigidbody2D rb;

    private Player_GroundDetection PGD;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PGD = GetComponent<Player_GroundDetection>();
    }

    void Update () {
        moveDir = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveSpeed * moveDir, rb.velocity.y);

        //dir is a float equal to the "horizontal axis input," this helps us move the character,  because in update
        //we are constantly updating the character rigid body velocity (rb.velocity)
        //this means that each frame, the velocity has a new value
        //that value will be a new Vector2 every frame
        //its values are (moveSpeed*dir, rb.velocity.y)...for this example say moveSpeed is 5
        //this means the x coordinate for the Vector2 will be 5*dir(dir can be between -1 and 1)
        //if 5*-1 for example, the new Vector2 will be -5 for the x coordinate, meaning the character will move left

        if (Mathf.Ceil(moveDir) > 0)
        {
            transform.localScale = new Vector3(5, 5, 1);
            isRightFacing = true;
        }
        else if (Mathf.Floor(moveDir) < 0)
        {
            isRightFacing = false;
            transform.localScale = new Vector3(-5, 5, 1);
        }

        if (Input.GetButtonDown("Jump") && PGD.isGrounded){
            Jump();
        }

	}

    void Jump()
    {
        PGD.isGrounded = false;
        rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed), ForceMode2D.Impulse);
    }
}
