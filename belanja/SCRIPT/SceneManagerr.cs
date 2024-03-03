using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerr : MonoBehaviour
{
    public GameObject QuizPanel;
    public GameObject AnswerPanel;
    public GameObject GOPanel;
    // Start is called before the first frame update
    private void Start()
    {
        GOPanel.SetActive(false);
        AnswerPanel.SetActive(false);
        QuizPanel.SetActive(true);
    }

    public void Game()
    {
        GOPanel.SetActive(false);
        AnswerPanel.SetActive(true);
        QuizPanel.SetActive(false);
    }

    public void GameOver()
    {
        GOPanel.SetActive(false);
        AnswerPanel.SetActive(false);
        QuizPanel.SetActive(true);
    }

}


