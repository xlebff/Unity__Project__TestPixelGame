using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notes : MonoBehaviour
{
    [SerializeField] GameObject main;
    [SerializeField] TMP_Text text;
    [SerializeField] Animator[] anim;

    public string[] anim_name;
    public string notes;

    private void OnMouseDown()
    {
        switch (notes) {
            case "macsw":
                text.text = "yyyui i\n[[[[po o\nt e u t";
                    break;
            case "year":
                text.text = "/// /// /w,./\nqqq /// /../. w";
                break;
            case "mega":
                text.text = "..y e 3wq .qw\n,,y e 3wq .qw\nmmy e 3wq .qw\njjy e 3wq .qw";
                break;
            case "shark":
                text.text = ". / www ww ww\n. / www ww ww\n. / www ww ww\nw w 2";
                break;
        }
        for (int i = 0; i < anim.Length; i++)
        {
            anim[i].Play(anim_name[i]);
        }
    }

    public void Disable()
    {
        main.SetActive(false);
    }
}
