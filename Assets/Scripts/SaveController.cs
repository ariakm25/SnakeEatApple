using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveController : MonoBehaviour
{
    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void Save1()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        PlayerPrefs.SetInt("savedGame1", lastScore);
        PlayerPrefs.Save();

        GameObject.Find("Save 1").GetComponentInChildren<Text>().text =
            "Save 1 (" + lastScore + ")";
    }

    public void Save2()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        PlayerPrefs.SetInt("savedGame2", lastScore);
        PlayerPrefs.Save();
        GameObject.Find("Save 2").GetComponentInChildren<Text>().text =
            "Save 2 (" + lastScore + ")";
    }

    public void Save3()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        PlayerPrefs.SetInt("savedGame3", lastScore);
        PlayerPrefs.Save();
        GameObject.Find("Save 3").GetComponentInChildren<Text>().text =
            "Save 3 (" + lastScore + ")";
    }

    public void Save4()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        PlayerPrefs.SetInt("savedGame4", lastScore);
        PlayerPrefs.Save();
        GameObject.Find("Save 4").GetComponentInChildren<Text>().text =
            "Save 4 (" + lastScore + ")";
    }

    public void Save5()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        PlayerPrefs.SetInt("savedGame5", lastScore);
        PlayerPrefs.Save();
        GameObject.Find("Save 5").GetComponentInChildren<Text>().text =
            "Save 5 (" + lastScore + ")";
    }
}
