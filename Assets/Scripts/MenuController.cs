using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void PlayGame()
	{
		// TODO - Load the game scene
	}

	public void LeaderBoard()
	{
		SceneManager.LoadScene("Leaderboard");
	}

	public void QuitGame()
	{
		Debug.Log("Quitting Game");
		Application.Quit();
	}
}
