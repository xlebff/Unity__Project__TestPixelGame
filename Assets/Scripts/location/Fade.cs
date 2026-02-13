using UnityEngine;

public class Fade : MonoBehaviour
{
    [SerializeField] Animator fade;

    public string next;
    public Vector3 pos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fade.Play("start");
    }
}
