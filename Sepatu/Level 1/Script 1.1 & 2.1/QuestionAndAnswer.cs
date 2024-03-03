using UnityEngine;
[System.Serializable]
public class QuestionAndAnswer
{
    public string Question;
    public AudioClip questionAudioClip;
    public Sprite[] Answer;

    public int CorrectAnswer; // Index of the correct answer (0, 1, or 2)
    public AudioClip correctAudioClip;

    public int wrongAnswerIndex1; // Index of the first wrong answer (0, 1, or 2)
    public AudioClip wrongAudioClip1;

    public int wrongAnswerIndex2; // Index of the second wrong answer (0, 1, or 2)
    public AudioClip wrongAudioClip2;
}


