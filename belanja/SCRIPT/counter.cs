using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class counter : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private TMP_Text apelCounter, melonCounter, jerukCounter;
    public int apelAmount, melonAmount, jerukAmount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        apelAmount = 0;
        melonAmount = 0;
        jerukAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        apelCounter.text = "= " + apelAmount;
        melonCounter.text = "= " + melonAmount;
        jerukCounter.text = "= " + jerukAmount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<apel>())
        {
            apelAmount += 1;
        }
        else if (collision.GetComponent<melon>())
        {
            melonAmount += 1;
        }
        else if (collision.GetComponent<jeruk>())
        {
            jerukAmount += 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<apel>())
        {
            apelAmount -= 1;
        }
        else if (collision.GetComponent<melon>())
        {
            melonAmount -= 1;
        }
        else if (collision.GetComponent<jeruk>())
        {
            jerukAmount -= 1;
        }
    }
}
