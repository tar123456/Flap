using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreViewer : MonoBehaviour
{
    int HighScore;
    Text highScoreText;
    void Start()
    {       
        HighScore = PlayerPrefs.GetInt("HighScore",0); 
        highScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = HighScore.ToString();
    }
}
