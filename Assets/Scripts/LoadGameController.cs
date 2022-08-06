using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGameController : MonoBehaviour
{
    public Button loadGameButton1;
    public Button loadGameButton2;
    public Button loadGameButton3;
    public Button loadGameButton4;
    public Button loadGameButton5;

    int savedGame1 = 0;
    int savedGame2 = 0;
    int savedGame3 = 0;
    int savedGame4 = 0;
    int savedGame5 = 0;

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }

    void OnEnable()
    {
        savedGame1 = PlayerPrefs.GetInt("savedGame1", 0);
        savedGame2 = PlayerPrefs.GetInt("savedGame2", 0);
        savedGame3 = PlayerPrefs.GetInt("savedGame3", 0);
        savedGame4 = PlayerPrefs.GetInt("savedGame4", 0);
        savedGame5 = PlayerPrefs.GetInt("savedGame5", 0);

        if (savedGame1 >= 1)
        {
            loadGameButton1.interactable = true;
            loadGameButton1.GetComponentInChildren<Text>().text =
                "Load Game 1 (" + savedGame1 + ")";
        }
        else
        {
            loadGameButton1.interactable = false;
        }

        if (savedGame2 >= 1)
        {
            loadGameButton2.interactable = true;
            loadGameButton2.GetComponentInChildren<Text>().text =
                "Load Game 2 (" + savedGame2 + ")";
        }
        else
        {
            loadGameButton2.interactable = false;
        }

        if (savedGame3 >= 1)
        {
            loadGameButton3.interactable = true;
            loadGameButton3.GetComponentInChildren<Text>().text =
                "Load Game 3 (" + savedGame3 + ")";
        }
        else
        {
            loadGameButton3.interactable = false;
        }

        if (savedGame4 >= 1)
        {
            loadGameButton4.interactable = true;
            loadGameButton4.GetComponentInChildren<Text>().text =
                "Load Game 4 (" + savedGame4 + ")";
        }
        else
        {
            loadGameButton4.interactable = false;
        }

        if (savedGame5 >= 1)
        {
            loadGameButton5.interactable = true;
            loadGameButton5.GetComponentInChildren<Text>().text =
                "Load Game 5 (" + savedGame5 + ")";
        }
        else
        {
            loadGameButton5.interactable = false;
        }
    }

    public void LoadGame1()
    {
        Debug.Log("LoadGame1");
        StateController.initialScore = savedGame1;
        SceneManager.LoadScene("Loading");
    }

    public void LoadGame2()
    {
        StateController.initialScore = savedGame2;
        SceneManager.LoadScene("Loading");
    }

    public void LoadGame3()
    {
        StateController.initialScore = savedGame3;
        SceneManager.LoadScene("Loading");
    }

    public void LoadGame4()
    {
        StateController.initialScore = savedGame4;
        SceneManager.LoadScene("Loading");
    }

    public void LoadGame5()
    {
        StateController.initialScore = savedGame5;
        SceneManager.LoadScene("Loading");
    }
}
