using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
   public bool isCorrect = false;
   public QuizManagerB quizManager;

   [HideInInspector]public AudioClip sound;

   public void Answer()
   {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            StartCoroutine(quizManager.correct(sound));
        }
        else
        {
            Debug.Log("Incorrect Answer");
            quizManager.incorrect(sound);
        }
   }
}




