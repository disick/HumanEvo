using UnityEngine;

public class DoorTriggerManual : MonoBehaviour
{
    public DoorController door;
    public bool triggered;

    void Update()
    {
        if(triggered && Input.GetKeyDown(KeyCode.F))
        {
            door.Use();
        }
    }

    public void OnTriggerEnter()
    {
        triggered = true;
    }

    public void OnTriggerExit()
    {
        triggered = false;
    }

    public void OnGUI()
    {
        if(triggered) GUI.Box(new Rect(new Vector2(Screen.width / 2 - Screen.width / 12, Screen.height / 2 + Screen.height / 8), new Vector2(Screen.width / 6, Screen.height / 24)), "Press F to use the door.");
    }
}
