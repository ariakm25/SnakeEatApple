using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    private IEnumerator coroutine;

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnEnable()
    {
        coroutine = LoadingAndPlayGame(1);
        StartCoroutine(coroutine);
    }

    IEnumerator LoadingAndPlayGame(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Play");
    }
}
