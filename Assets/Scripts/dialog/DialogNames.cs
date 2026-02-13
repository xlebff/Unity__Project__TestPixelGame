using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogNames : MonoBehaviour
{
    [SerializeField] Dialog main;
    [SerializeField] GameObject window;
    [SerializeField] TMP_Text text;

    public int[] sent;
    public string c_name;

    private void Start()
    {
        
    }
    public void Check()
    {
        for (int i = 0; i < sent.Length - 1; i++)
        {
            if (sent[i] == main.i)
            {
                window.SetActive(true);
                text.text = c_name;
            } else
            {
                text.text = "";
                window.SetActive(false);
            }
        }
    }
}
