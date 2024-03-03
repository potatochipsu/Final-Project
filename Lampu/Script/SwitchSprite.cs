using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchSprite : MonoBehaviour
{
    public GameController gameController;

    public LampController lamp;

    public Image img;
    public Sprite on;
    public Sprite off;

    public void SwitchingLamp()
    {
        if (gameController.questionLampsRunning == false && lamp.lampActive == false)
        {
            lamp.Switch();
            img.sprite = on;
            gameController.AddAnswer(lamp);
        }
        else
        {
            Debug.Log("Cannot switch sprite while QuestionLamps is running.");
        }
    }
    public void ButtonOff()
    {
        img.sprite = off;
    }
}
