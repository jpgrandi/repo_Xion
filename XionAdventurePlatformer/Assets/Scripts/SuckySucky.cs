using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuckySucky : MonoBehaviour {

    [Header("0 = Vertical, 1 = Horizontal")]
    public int direction;

    private Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = new Vector2(rb.velocity.x*direction, 0); 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        rb.gravityScale = 2;
        rb.velocity = new Vector2(0, 0);
    }
   
}
