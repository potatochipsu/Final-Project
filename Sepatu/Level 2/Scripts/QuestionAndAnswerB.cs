using UnityEngine;
[System.Serializable]

public class QuestionAndAnswerB
{
    public string Question;
    public AudioClip quesAudio;
    public Sprite[] Answer;

    public int CorrectAnswer;
    public AudioClip correctAudio;

    public int WrongAnswer1;
    public AudioClip incorrectAudio1;

    public int WrongAnswer2;
    public AudioClip incorrectAudio2;
}
