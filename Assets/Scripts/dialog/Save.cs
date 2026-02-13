using System;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] CharInfo info;
    [SerializeField] Health health;
    [SerializeField] Manager m;
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
        if (en && m.GetStat() == 1)
        {
            Debug.Log("saved");
            health.health = health.maxHealth;
            info.setSave();
        }
    }
}
