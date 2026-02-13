using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerChanger : MonoBehaviour
{
    private Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        render.sortingOrder = 3;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        render.sortingOrder = 1;
    }
}
