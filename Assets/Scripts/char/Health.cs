using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public void Death()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private IEnumerator Poisoning(int level, int duraction)
    {
        for (int i = duraction; i > 0; i--)
        {
            health -= level;
            Death();
            yield return new WaitForSeconds(1);
        }
    }

    public void GetDamage(int damage)
    {
        if (health <= damage)
        {
            health = 0;
            Death();
        }
        else health -= damage;
    }

    public void GetDamage(int level, int duraction)
    {
        StartCoroutine(Poisoning(level, duraction));
    }

    public void GetHeal(int heal)
    {
        if (maxHealth - health < heal)
        {
            health = maxHealth;
        }
        else health += heal;
    }

    public void GetHeal(int heal, int duraction)
    {
        StartCoroutine(Healing(heal, duraction));
    }

    private IEnumerator Healing(int heal, int duraction)
    {
        for (int i = duraction; i > 0; i--)
        {
            if (maxHealth - health < heal)
            {
                health = maxHealth;
            }
            else health += heal;
            yield return new WaitForSeconds(1);
        }
    }
}
