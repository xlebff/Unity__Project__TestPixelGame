using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [SerializeField] Sprite basic;
    [SerializeField] Sprite pressed;

    public string keyName;

    private Image imge;
    public void Start()
    {
        imge = GetComponent<Image>();
    }
    private void Update()
    {
        if (Input.GetKey(keyName)) imge.sprite = pressed;
        else imge.sprite = basic;
    }
}
