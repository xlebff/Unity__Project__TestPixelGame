using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProfile : MonoBehaviour
{
    [SerializeField] Health charHealth;

    public int health;
    public int maxHealth;
    public int level;
    public int attack;
    public int def;
    public int phisicalDef;
    public int elementalDef;

    public void enemyAttack(int damage)
    {
        charHealth.GetDamage(damage * (attack / 10));
    }
}
