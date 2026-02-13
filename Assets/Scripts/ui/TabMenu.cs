using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabMenu : MonoBehaviour
{
    private GameObject names;
    private bool active = true;

    private void Start()
    {
        names = GameObject.FindGameObjectWithTag("TabMenu");
    }
    private void Update()
    {
        if (Input.GetButtonDown("TabMenu"))
        {
            if (!active)
            {
                names.SetActive(true);
                active = true;
            } else if (active)
            {
                names.SetActive(false);
                active = false;
            }
        }
    }
}
