using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharInfo : MonoBehaviour
{
    [SerializeField]
    Health health;

    int level, attack, phisicalDef, elementalDef;

    private int startLevel = 1;
    private int startAttack = 10;
    private int startPhisicalDef = 3;
    private int startElementalDef = 0;

    [SerializeField] 
    private int[] needExp;
    public int exp;

    private void Start()
    {
        LevelUp();
        getSave();
        ParametrsUpdate();
    }

    public void LevelUp()
    {
        if (needExp[level] <= exp)
        {
            level++;
            ParametrsUpdate();
            exp -= needExp[level];
        }
    }

    private void ParametrsUpdate()
    {
        for (int i = level; i > 0; i--)
        {
            health.maxHealth += 5;
            attack += 3;
            phisicalDef += 5;
            elementalDef += 3;
        }
    }

    public void getSave()
    {
        level = PlayerPrefs.GetInt("savedLevel");
        exp = PlayerPrefs.GetInt("savedExp");
    }

    public void setSave()
    {
        PlayerPrefs.SetInt("savedLevel", level);
        PlayerPrefs.SetInt("savedExp", exp);
        //PlayerPrefs.SetInt("savedPhisicalDef", phisicalDef);
        //PlayerPrefs.SetInt("savedElementalDef", elementalDef);
        //PlayerPrefs.SetInt("savedAttack", attack);
    }
}
