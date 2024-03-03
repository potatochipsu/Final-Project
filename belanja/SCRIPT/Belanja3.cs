using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Belanja3 : MonoBehaviour
{
    public int jmlApel, jmlMelon, jmlJeruk;
    public counter Counter;
    public Button button;
    public AudioSource wrongSound;
    public AudioSource rightSound;
    public GameObject AnsPanel;
    public GameObject GOpanel;
    private int numOfRepeats;

    // Start is called before the first frame update
    public void Start()
    {
        if (button == null)
            button = GetComponent<Button>();

        button.onClick.AddListener(PlayClickSound);
    }

    // Update is called once per frame
    public void Update()
    {
    }

    public void PlayClickSound()
    {
        if (Counter.apelAmount == jmlApel && Counter.melonAmount == jmlMelon && Counter.jerukAmount == jmlJeruk)
            rightSound.Play();
        else
            wrongSound.Play();
    }

    public void Clicked()
    {
        if (Counter.apelAmount == jmlApel && Counter.melonAmount == jmlMelon && Counter.jerukAmount == jmlJeruk)
        {
            Debug.Log("Correct answer!");
            AnsPanel.SetActive(false);
            GOpanel.SetActive(true);
        }
        else
        {
            Debug.Log("Wrong answer!");
            numOfRepeats++;
            Debug.Log(numOfRepeats);
        }
    }
}
