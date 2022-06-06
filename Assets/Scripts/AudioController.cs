using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	public void Mute()
	{
		AudioListener.pause = true;
	}

	public void UnMute()
	{
		AudioListener.pause = false;
	}
}
