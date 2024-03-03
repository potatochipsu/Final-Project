using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using Unity.VisualScripting;

public class QuizManager : MonoBehaviour
{
    public static QuizManager Instance;

    public bool gamePlaying { get; private set; }

    public List<QuestionAndAnswer> QnA;
    public GameObject[] option;
    public int currentQuestion = 0;

    public GameObject Quizpanel; // Quiz Manager
    public GameObject Starpanel; // Hebat 

    public TMP_Text QuestionTxt;

    public AudioSource src;

    private int numAttempt = 0;

    int totalQuestions = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        totalQuestions = QnA.Count; // Scene managaer on how much the quoestion on the game
        Starpanel.SetActive(false); 
        generateQuestion();
        gamePlaying = false;

        BeginGame();
    }

    private void BeginGame()
    {
        gamePlaying = true;
    }

    public void StarsScene()
    {
        Quizpanel.SetActive(false);
        Starpanel.SetActive(true);
    }

    // Generate, if the answer is correct then generate new question
    public IEnumerator correct(AudioClip Clip)
    {
        src.clip = Clip;
        src.Play(); 
        QnA.RemoveAt(currentQuestion); // This scene will remove the current game scene
        yield return new WaitForSeconds (1f);
        generateQuestion(); // then generating the next question scene
        // totalAtt();
    }

    public void wrong(AudioClip Clip)
    {
        src.clip = Clip;
        src.Play();
        totalAtt();
    }

    // This is reference for putting the right answer on the unity (elemen)
    void SetAnswer() 
    {
        for(int i = 0; i < option.Length; i++)
        {
            option[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answer[i];

            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {
                option[i].GetComponent<AnswerScript>().isCorrect = true;
                option[i].GetComponent<AnswerScript>().sound = QnA[currentQuestion].correctAudioClip;
            }
            
            else if (QnA[currentQuestion].wrongAnswerIndex1 == i + 1)
            {
                option[i].GetComponent<AnswerScript>().isCorrect = false;
                option[i].GetComponent<AnswerScript>().sound = QnA[currentQuestion].wrongAudioClip1;
            }

            else if (QnA[currentQuestion].wrongAnswerIndex2 == i + 1)
            {
                option[i].GetComponent<AnswerScript>().isCorrect = false;
                option[i].GetComponent<AnswerScript>().sound = QnA[currentQuestion].wrongAudioClip2;
            }
        }
    }

    // This is reference for generating the next question after the right answer button is clicked
    void generateQuestion() 
    {
        if (QnA.Count > 0)
        {
            //soundManager.src = QnA.Question;
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            QuestionSound();
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of Question");
            StarsScene();
        }
    }
    public void QuestionSound()
    {
        src.clip = QnA[currentQuestion].questionAudioClip;
        src.Play();
    }

    public void totalAtt()
    {
        numAttempt++;
        Debug.Log(numAttempt);
    }

    /*
    private int GetCurrentQuestion()
    {
        return currentQuestion;
    }
    */

    /*
    void retryQuestion(int currentQuestion)
    {
        if (QnA.Count > 0)
        {
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswer();
        }
        else
        {
            Debug.Log("Retry Question");
        }
    }
    */
}
