using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingController : MonoBehaviour
{
    public Slider speedSetting;

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnEnable()
    {
        speedSetting.value = PlayerPrefs.GetFloat("Speed", 0.5f);
    }

    public void SaveSetting()
    {
        Debug.Log("Saved");
        PlayerPrefs.SetFloat("Speed", speedSetting.value);
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}
