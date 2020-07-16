using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    public float timer = 0f;
    public float timerEnd = 03f;
    public bool timerCounting;

    public bool isOpen = false;

    void OnTriggerEnter(Collider col)
    {
        if (!isOpen)
        {
            isOpen = true;
            door.transform.position += new Vector3(0, 4, 0);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        timerCounting = true;
    }
    private void Update()
    {

        if (timerCounting)
        {
            timer += Time.deltaTime;// ksekinaei timer \
            if (timer > timerEnd) // otan teleisei
            {

                DoorClose();

            }
        }
    }
    void DoorClose() // methodo gia to klisimo ths portas1
    {

        door.transform.position += new Vector3(0, -4, 0);
        isOpen = false;
        timerCounting = false;
        timer = 0;

    }

}