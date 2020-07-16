using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    // The gameobject / UI that has the instructions for the player "Press 'E' to interact."
    public GameObject instructions;

    // As long as we are colliding with a trigger collider
    private void OnTriggerStay(Collider other)
    {
        // Check if the object has the tag 'Door'
        if (other.tag == "Door")
        {
            // Show the instructions
            instructions.SetActive(true);
            // Get the Animator from the child of the door (If you have the Animator component in the parent,
            // then change it to "GetComponent")
            Animator anim = other.GetComponentInChildren<Animator>();
            // Check if the player hits the "E" key
            if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("OpenClose"); //Set the trigger "OpenClose" which is in the Animator
        }
    }

    // Once we exit colliding with a trigger collider
    private void OnTriggerExit(Collider other)
    {
        // Check it is a door
        if (other.tag == "Door")
        {
            // Hide instructions
            instructions.SetActive(false);
        }
    }
}
