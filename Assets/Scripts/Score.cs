using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class Score : MonoBehaviour
{

    public Text MyScoreText;
    private int ScoreNumber;
    
    void Start()
    {
        ScoreNumber = 0;
        MyScoreText.text = "Score: " + ScoreNumber;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            ScoreNumber += 1;
            MyScoreText.text = "Score: " + ScoreNumber;
            GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>().text = "Score: " + ScoreNumber;
        }
    }

    void Update()
    {
        
    }
}
