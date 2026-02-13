using UnityEngine;
using TMPro;

public class Changer : MonoBehaviour
{
    [SerializeField] GameObject[] mod;
    [SerializeField] Animator[] anim_mod;
    [SerializeField] TMP_Text text;

    public string[] hide;

    public bool active = false;

    private void OnMouseDown()
    {
        if (!active)
        {
            text.text = "";
            for (int i = 0; i < mod.Length; i++) mod[i].SetActive(true);
            active = true;
        } else
        {
            for (int i = 0; i < mod.Length; i++) anim_mod[i].Play(hide[i]);
            active = false;
        }
    }
}
