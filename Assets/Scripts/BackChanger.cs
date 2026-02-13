using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BackChanger : MonoBehaviour
{
    [SerializeField] VideoPlayer[] video;
    [SerializeField] GameObject main;
    public string name;

    private void OnMouseDown()
    {
        switch (name) {
            case "sakura":
                for (int i = 0; i < video.Length; i++)
                {
                    video[i].enabled = false;
                }
                video[0].enabled = true;
                break;
            case "tree":
                for (int i = 0; i < video.Length; i++)
                {
                    video[i].enabled = false;
                }
                video[1].enabled = true;
                break;
        }
    }
    public void Disable()
    {
        main.SetActive(false);
    }
}
