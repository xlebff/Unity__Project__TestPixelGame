using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class AnswersManager : MonoBehaviour
{
    [SerializeField] Dialog dialog;
    [SerializeField] Manager m;

    [SerializeField] string[] one;
    [SerializeField] string[] two;

    [SerializeField] int answer;
    [SerializeField] int answersCount;
    [SerializeField] string[] answerText;

    [SerializeField] TMP_Text[] answerTextboard;
    [SerializeField] Animator[] answers;

    private void Update()
    {
        switch (m.GetStat())
        {
            case 1:
                Button1();
                m.SetStat(0);
                break;
            case 2:
                Button2();
                m.SetStat(0);
                break;
        }
    }

    public bool Check()
    {
        if (answer == dialog.i)
        {
            dialog.active = false;
            for (int k = 0; k < answersCount; k++)
            {
                answerTextboard[k].text = answerText[k];
                answers[k].Play("answer_idle");
            }
            return true;
        }
        else
        {
            for (int k = 0; k < answers.Length; k++)
            {
                answers[k].Play("answer_hide");
            }
            for (int k = 0; k < answerTextboard.Length; k++)
            {
                answerTextboard[k].text = "";
            }
            return false;
        }
    }

    public void Button1()
    {
        dialog.active = false;
        Array.Resize<string>(ref dialog.sentence, dialog.sentence.Length + one.Length);
        one.CopyTo(dialog.sentence, dialog.startLenght);
        dialog.Clear();
        dialog.Change_Text();
    }

    public void Button2()
    {
        dialog.active = false;
        Array.Resize<string>(ref dialog.sentence, dialog.sentence.Length + two.Length);
        two.CopyTo(dialog.sentence, dialog.startLenght);
        dialog.Clear();
        dialog.Change_Text();
    }
}
