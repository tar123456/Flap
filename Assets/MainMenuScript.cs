using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void quitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
