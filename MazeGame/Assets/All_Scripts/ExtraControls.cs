using UnityEngine;
using System.Collections;

public class ExtraControls : MonoBehaviour {
	public GUIText instructions;
	private bool instructionsEnabled;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.I))
		{
			instructionsEnabled = !instructionsEnabled;
		}

		if(instructionsEnabled)
		{
			instructions.guiText.enabled = true;
		}

		if(!instructionsEnabled)
		{
			instructions.guiText.enabled = false;
		}
	
	}
}
