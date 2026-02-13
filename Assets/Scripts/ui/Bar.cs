using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] Image staminaBar;
    [SerializeField] Image staminaBorder;
    [SerializeField] Stamina stamina;

    [SerializeField] Image healthBar;
    [SerializeField] Image healthBorder;
    [SerializeField] Health health;

    private bool en = true;

    private void Update()
    {
        if (stamina.stamina != stamina.maxStamina)
        {
            en = true;
            if (staminaBorder.color.a == 0f) { StartCoroutine(StaminaAppear()); }
            staminaBar.fillAmount = (float)stamina.stamina / (float)stamina.maxStamina;
        }
        else if (staminaBorder.color.a != 0f && en) { StartCoroutine(StaminaDisappear()); }

        healthBar.fillAmount = (float)health.health / (float)health.maxHealth;
    }

    IEnumerator StaminaAppear()
    {
        for (float i = 1; i < 100; i++)
        {
            staminaBorder.color = new Color(1f, 1f, 1f, (float)(i / 100));
            staminaBar.color = new Color(1f, 1f, 1f, (float)(i / 100));
            yield return new WaitForSeconds(0.005f);
        }
    }

    IEnumerator StaminaDisappear()
    {
        en = false;
        for (float i = 100; i > 1; i--)
        {
            staminaBorder.color = new Color(1f, 1f, 1f, (float)(i / 100));
            staminaBar.color = new Color(1f, 1f, 1f, (float)(i / 100));
            yield return new WaitForSeconds(0.005f);
        }
        Debug.Log("a");
        staminaBorder.color = new Color(1f, 1f, 1f, 0f);
        staminaBar.color = new Color(1f, 1f, 1f, 0f);
    }
}
