﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickables"))
        {
            other.gameObject.GetComponent<gunInteraction>().isPickable();
        }
    }
}
