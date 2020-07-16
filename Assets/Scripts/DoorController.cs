using UnityEngine;

public class DoorController : MonoBehaviour
{
    [Header("Door States")]
    public bool isOpen;

    [Header("Audio")]
    public AudioSource aud;
    public AudioClip openSound;
    public AudioClip closeSound;

    [Header("References")]
    public Animator anim;
    public Transform hinge;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    public void Open()
    {
        isOpen = true;
        aud.PlayOneShot(openSound);
        anim.SetTrigger("UseDoor");
    }

    public void Close()
    {
        isOpen = false;
        aud.PlayOneShot(closeSound);
        anim.SetTrigger("UseDoor");
    }

    public void Use()
    {
        if (!isOpen)    Open();
        else            Close();
    }
}
