using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSound : MonoBehaviour
{
    [SerializeField] AudioSource[] steps;
    [SerializeField] AudioSource jerk;

    int main;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "rock")
        {
            main = 0;
        }
    }

    public void Step()
    {
        steps[main].Play();
    }

    public void Jerk()
    {
        jerk.Play();
    }
}
