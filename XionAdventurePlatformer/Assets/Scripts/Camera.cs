﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject player;
    public Transform cameraPos;
    private Player_Movement PM;

    public float offsetX;
    public float offsetY;

    private Vector3 targetPosition;
    private Vector3 vel = Vector3.zero;
    public float smoothTime;

    private void Awake()
    {
        PM = player.GetComponent<Player_Movement>();
        cameraPos.position = transform.position + new Vector3(offsetX, offsetY, -20);
    }

    private void FixedUpdate()
    {
        if (PM.isRightFacing)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, smoothTime);
            Debug.Log("Is Right Facing");
            
        }
        else if (!PM.isRightFacing)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, smoothTime);
            Debug.Log("Is Left Facing");
        }

        targetPosition = cameraPos.position;
    }

}