using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickupMethod();
        Destroy(gameObject);
    }

    virtual protected void PickupMethod()
    {
        Debug.Log("object picked up");
    }

}
