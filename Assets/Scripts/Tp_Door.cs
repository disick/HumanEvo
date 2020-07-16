using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_Door : MonoBehaviour
{

    public GameObject TP_point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.position = TP_point.transform.position;
        }
    }
}
