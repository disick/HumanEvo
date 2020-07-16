using System.Threading;
using UnityEngine;

public class DoorTriggerAuto : MonoBehaviour
{
    public DoorController door;
    public bool triggered;
    public float doorTimerCurrent;
    public float doorTimerEnd;

    void Update()
    {
        if(triggered)
        {
            door.Open();
        }
    }

    public void OnTriggerEnter()
    {
        triggered = true;
    }

    public void OnTriggerExit()
    {

    }

    public void OnGUI()
    {
        if(triggered) GUI.Box(new Rect(new Vector2(Screen.width / 2 - Screen.width / 12, Screen.height / 2 + Screen.height / 8), new Vector2(Screen.width / 6, Screen.height / 24)), "Press F to use the door.");
    }
}
