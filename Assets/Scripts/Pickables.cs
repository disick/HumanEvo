using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickables : MonoBehaviour
{
    
    public Transform hand;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log(collider.name);
            this.transform.position = hand.position;
            this.transform.parent = GameObject.Find("Hand").transform;
            
            //hand.localRotation = Quaternion.Slerp(hand.localRotation, transform.localRotation, 0.1f);
        }
    }
}
