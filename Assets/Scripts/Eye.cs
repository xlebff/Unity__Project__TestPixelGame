using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Eye : MonoBehaviour
{
    [SerializeField] TMP_Text[] text;
    [SerializeField] Animator anim;

    bool active = true;

    public void OnMouseDown()
    {
        if (active) Disable();
        else Enable();
    }

    private void Disable()
    {
        anim.Play("close");
        for (int i = 0; i < text.Length - 1; i++)
        {
            text[i].enabled = false;
        }
        active = false;
    }
    private void Enable()
    {
        anim.Play("show");
        for (int i = 0; i < text.Length - 1; i++)
        {
            text[i].enabled = true;
        }
        active = true;
    }
    public void Anim()
    {
        anim.Play("eye");
    }
}
