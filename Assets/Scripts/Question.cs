using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;


public class Question : MonoBehaviour
{
    [SerializeField] Text[] Questions;
    [SerializeField] TMP_Text[] OptionsText;
    [SerializeField] TMP_Text QuestionText;

    int CurrentQuestion;

    public void NewQuestion ()
    {
        CurrentQuestion = Random.Range(0, Questions.Length);
        string[] QuestionDetails = Questions[CurrentQuestion].text.Split('@');
        for (int option = 0; option < 4; option++)
        {
            OptionsText[option].text = QuestionDetails[1 + option];
        }
        QuestionText.text = QuestionDetails[0];
    }

    public static void Answer (string option)
    {
        string[] QuestionDetails = Questions[CurrentQuestion].text.Split('@');
        if (option == QuestionDetails[5])
        {
            GameManager.PatientsHealed++;
            Destroy(this);
        }
        else
        {

        }
    }
}
