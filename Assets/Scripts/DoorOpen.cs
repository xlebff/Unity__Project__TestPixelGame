using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField]
    AudioSource sound;
    [SerializeField]
    string openName;
    [SerializeField]
    string closeName;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            sound.Play();
            anim.enabled = true;
            anim.Play(openName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sound.Play();
            anim.Play(closeName);
        }
    }
}
