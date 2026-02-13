using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCheck : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject cube;
    private void Update()
    {
        if (text.text != "")
        {
            cube.SetActive(true);
        }
        else cube.SetActive(false);
    }
}
