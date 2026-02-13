using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    ArrayList branch = new ArrayList();
    ArrayList done = new ArrayList();
    public int points;

    private void Start()
    {
        done.Add("BasicAtack");
        branch.Add("BasicAtack");
        branch.Add("2");
        branch.Add("3");
        branch.Add("4");
        branch.Add("5");
    }

    public void Buy(int skillNumber)
    {
        if (done.Contains(branch[skillNumber])) Debug.LogWarning("Навык уже получен");
        else if (points > 0 && done.Contains(branch[skillNumber - 1]))
        {
            done.Add(branch[skillNumber]);
            Debug.Log("Навык приобретён!");
            points--;
        }
        else if (points == 0) Debug.LogError("Недостаточно очков");
        else if (!done.Contains(branch[skillNumber - 1])) Debug.LogError("Навык недоступен");
    }

    public bool Check(int skillNumber)
    {
        return done.Contains(branch[skillNumber]);
    }
}
