using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using System.Collections;

public class LocName : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public string str;
    public bool battle;
    private Animator anim;

    private void Start()
    {
        anim = text.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.text = str;
        anim.Play("appear");
        Delay();
    }

    async void Delay()
    {
        await Task.Delay(3000);
        anim.Play("disappear");
    }
}
