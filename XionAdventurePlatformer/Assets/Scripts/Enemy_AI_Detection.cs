using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Detection : MonoBehaviour {

    public bool isTouchingGround;

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTouchingGround = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTouchingGround = true;
    }
}
