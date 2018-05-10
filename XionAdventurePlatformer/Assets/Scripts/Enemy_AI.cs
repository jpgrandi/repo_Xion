using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour {

    public float moveSpeed;

    private Rigidbody2D rb;

    private GameObject detectionBox;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        detectionBox = gameObject.transform.GetChild(0).gameObject;

    }

    private void Update()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
        if (!detectionBox.GetComponent<Enemy_AI_Detection>().isTouchingGround)
        {
            moveSpeed = -moveSpeed;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
