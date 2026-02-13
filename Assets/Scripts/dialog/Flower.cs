using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    [SerializeField] Dialog dialog;
    [SerializeField] Manager manager;

    bool en = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        en = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        en = false;
    }

    private void Update()
    {
        if (en && manager.GetStat() == 1)
        {
            Debug.Log("chanded");
            dialog.repeat = false;
            dialog.nextDialog = true;
            this.enabled = false;
            //newDialog.enabled = true;
        }
    }
}
