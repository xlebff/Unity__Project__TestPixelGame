using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    [SerializeField] NewMove move;
    public int stamina;
    public int maxStamina;
    public int jerkStamina;

    public bool RunCheck()
    {
        if (stamina > 1) return true;
        else return false;
    }

    public bool JerkCheck()
    {
        if (stamina >= jerkStamina) return true;
        else return false;
    }

    private void FixedUpdate()
    {
        if (move.run)
        {
            StopAllCoroutines();

            if (move.battle)
            {
                StopCoroutine(BattleLost());
            }
            else StartCoroutine(RunLost());
        }
        if (move.jerk)
        {
            StopAllCoroutines();
        }
        if (!move.run && !move.jerk && stamina != maxStamina)
        {
            StopAllCoroutines();
            StaminaRecDelay();
        }
    }

    async private void StaminaRecDelay()
    {
        await Task.Delay(500);
        StartCoroutine(StaminaRecover());
    }

    IEnumerator RunLost()
    {
        for (int i = stamina; i > 0; i--)
        {
            stamina--;
            RunCheck();
            yield return new WaitForSeconds(1000);
        }
    }
    IEnumerator BattleLost()
    {
        for (int i = stamina; i > 0; i--)
        {
            stamina--;
            RunCheck();
            yield return new WaitForSeconds(800);
        }
    }
    IEnumerator StaminaRecover()
    {
        for (int i = stamina; i < maxStamina; i++)
        {
            stamina++;
            yield return new WaitForSeconds(3.5f);
        }
    }
}
