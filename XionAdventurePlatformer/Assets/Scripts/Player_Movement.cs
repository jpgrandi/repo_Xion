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
