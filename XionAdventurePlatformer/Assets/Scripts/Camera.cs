using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject player;
    public Transform cameraPos;

    public float offsetX;
    public float offsetY;
    public float smoothTime;

    private Player_Movement PM;
    private Vector3 vel = Vector3.zero;

    private Vector3 targetPosition;

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