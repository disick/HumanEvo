using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunInteraction : MonoBehaviour, Interfaces
{
    public Transform hand;
    public void isPickable()
    {
        GetComponent<Collider>().enabled = false;
        transform.position = hand.position;
        transform.parent = hand;
        transform.localRotation = Quaternion.Euler(0f, 90f, 0f);        
    }
}
