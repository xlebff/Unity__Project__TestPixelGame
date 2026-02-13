using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Rain : MonoBehaviour
{
    [SerializeField] ParticleSystem rain;
    [SerializeField] AudioSource sound;
    [SerializeField] private bool enable;

    public bool rainActive;

    private int pause;
    private int play;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enable = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        enable = false;
    }

    private void Start()
    {
        if (enable)
        {
            rainActive = false;
            StartCoroutine(SoundStop());
            rain.Stop();
            pause = Random.Range(50000, 100000);
            play = Random.Range(50000, 80000);
            RainStart(pause);
        }
    }

    async private void RainStart(int i)
    {
        await Task.Delay(i);
        rain.Play();
        rainActive = true;
        RainStop(play);
    }

    async private void RainStop(int i)
    {
        StartCoroutine(SoundStart());
        await Task.Delay(i);
        Start();
    }

    IEnumerator SoundStart()
    {
        sound.Play();
        for (int i = 0; i < 100; i++)
        {
            sound.volume += 0.01f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator SoundStop()
    {
        for (int i = 0; i < 100; i++)
        {
            sound.volume -= 0.01f;
            yield return new WaitForSeconds(0.1f);
        }
        sound.Stop();
    }
}
