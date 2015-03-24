using UnityEngine;
using System.Collections;

public class ButtonsPressed : MonoBehaviour {


	// Update is called once per frame
	public void Replay (string levelName) {
		Application.LoadLevel(levelName);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void DisplayControls()
	{
		GameObject.Find("ControlText").guiText.enabled = true;
	}
	
}
