using System.Collections;
using System;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

public class Dialog : MonoBehaviour
{
    [SerializeField] TMP_Text dialog;
    [SerializeField] Animator window;
    [SerializeField] AudioSource voise;
    [SerializeField] NewMove move;
    [SerializeField] AnswersManager[] answer;
    [SerializeField] public string[] sentence;
    [SerializeField] public bool repeat;
    [SerializeField] public bool nextDialog;
    [SerializeField] Dialog next;
    
    public int i = -1;
    public int startLenght;
    public bool active;

    private void Start()
    {
        startLenght = sentence.Length;
    }

    public void Clear()
    {
        dialog.text = "";
    }

    public void Change_Text()
    {
        i++;
        if (i == 0)
        {
            First();
        }
        else if (i == sentence.Length)
        {
            End();
        }
        else
        {
            Next();
        }
    }

    async private void First()
    {
        move.Stop();
        move.enabled = false;
        window.Play("Open");
        await Task.Delay(400);
        StartCoroutine(Print());
        if (answer.Length > 0)
        {
            for (int k = 0; k < answer.Length; k++)
            {
                answer[k].enabled = true;
                answer[k].Check();
            }
        }
    }

    private void End()
    {
        move.enabled = true;
        move.Work();
        dialog.text = "";
        window.Play("Close");
        i = -1;
        active = true;
        if (answer.Length > 0)
        {
            for (int k = 0; k < answer.Length; k++)
            {
                answer[k].Check();
                answer[k].enabled = false;
            }
        }
        Array.Resize<string>(ref sentence, startLenght);
        if (nextDialog) { next.enabled = true; }
        if (!repeat) { this.enabled = false; }
    }

    private void Next()
    {
        if (answer.Length > 0)
        {
            for (int k = 0; k < answer.Length; k++)
            {
                answer[k].Check();
            }
        }
        move.enabled = false;
        dialog.text = "";
        StartCoroutine(Print());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        active = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        active = false;
    }

    void Update()
    {
        if (active)
        {
            if (Input.GetButtonDown("Interaction"))
            {
                if (dialog.text == "" || dialog.text == sentence[i])
                {
                    active = false;
                    Change_Text();
                }
                else
                {
                    StopAllCoroutines();
                    dialog.text = sentence[i];
                }
            }
        }
    }

    IEnumerator Print()
    {
        if (answer.Length > 0)
        {
            for (int k = 0; k < answer.Length; k++)
            {
                if (!answer[k].Check()) active = true;
            }
        }
        else { active = true; }
        for (int j = 0; j < sentence[i].Length; j++)
        {
            dialog.text += sentence[i][j];
            voise.Play();
            yield return new WaitForSeconds(0.02f);
        }
    }
}
