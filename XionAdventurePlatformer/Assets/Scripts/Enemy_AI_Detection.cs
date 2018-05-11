using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Detection : MonoBehaviour {

    public bool isTouchingGround;
    public bool isTouchingWall;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isTouchingGround = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTouchingGround = true;

        if (collision.gameObject.layer == 12)
        {
            isTouchingWall = true;
        }
    }
}
