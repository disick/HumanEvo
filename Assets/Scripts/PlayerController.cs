using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;

    void Update()
    {
        float hPos = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float vPos = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(0, 0, vPos);
        transform.Rotate(0, hPos, 0);
    }
}
