using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GroundDetection : MonoBehaviour {

    public bool isGrounded;
    public float r;

    public LayerMask cf2D;

    public float offsetY;

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(new Vector2(transform.position.x, (transform.position.y-offsetY)),r,cf2D);
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(new Vector2(transform.position.x, transform.position.y-offsetY), r);
    }
}
