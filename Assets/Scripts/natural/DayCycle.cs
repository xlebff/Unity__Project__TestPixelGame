using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [SerializeField] Light[] lights;
    [SerializeField] Light dir;

    public bool day;
    public bool night;

    private float maxLanternIntensivity;

    private void Start()
    {
        maxLanternIntensivity = lights[0].intensity;
        StartCoroutine(GlobalDown());
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].intensity = 0;
        }
    }

    private void Day()
    {
        night = false;
        day = true;
        for (int i = 0; i < lights.Length; i++)
        {
            StartCoroutine(Down(i));
        }
    }

    private void Night()
    {
        day = false;
        night = true;
        for (int i = 0; i < lights.Length; i++)
        {
            StartCoroutine(Up(i));
        }
    }

    IEnumerator Down(int k)
    {
        while (lights[k].intensity > 0)
        {
            lights[k].intensity -= 0.2f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator Up(int k)
    {
        while (lights[k].intensity <= maxLanternIntensivity)
        {
            lights[k].intensity += 0.2f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator GlobalDown()
    {
        while (dir.intensity > 0)
        {
            dir.intensity -= 0.0005f;
            if (!night && dir.intensity < 0.5)
            {
                Night();
            }
            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine(GlobalUp());
    }
    IEnumerator GlobalUp()
    {
        while (dir.intensity < 0.9)
        {
            dir.intensity += 0.0005f;
            if (!day && dir.intensity > 0.5)
            {
                Day();
            }
            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine(GlobalDown());
    }
}
