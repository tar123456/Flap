using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverObj;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreincrement)
    {
        playerScore = playerScore + scoreincrement;
        score.text = playerScore.ToString();
    }



    public void restartScent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void gameOver()
    { 
        gameOverObj.SetActive(true);
    }
}
