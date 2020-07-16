using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Trigger : MonoBehaviour
{

    public GameObject door;
    bool isOpen = false;
     void OnTriggerEnter(Collider collider)
    {
        if (isOpen == false)
        {
            isOpen = true;
            door.transform.position += new Vector3(0f, 4f, 0f);
        }
    }
}
