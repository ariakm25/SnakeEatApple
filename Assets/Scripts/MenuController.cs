using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Loading");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LoadGame");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void LoadScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        GameObject.Find("High Score").GetComponent<Text>().text = "High Score: " + highScore;
        GameObject.Find("Last Score").GetComponent<Text>().text = "Last Score: " + lastScore;
    }

    void OnEnable()
    {
        LoadScore();
    }
}
