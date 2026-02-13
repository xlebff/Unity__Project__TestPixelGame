using UnityEngine;
using System;

public class Manager : MonoBehaviour
{
    private int stat;

    public void SetStat(int set)
    {
        this.stat = set;
    }

    public int GetStat()
    {
        return stat;
    }
}
