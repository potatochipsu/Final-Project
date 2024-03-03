using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class AnswerScript3 : MonoBehaviour
{
    public QuizManager3 quizManager;
    public bool isCorrect;

    [HideInInspector]public AudioClip sound;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            StartCoroutine(quizManager.correct(sound));
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.wrong(sound);
        }
    }
}

