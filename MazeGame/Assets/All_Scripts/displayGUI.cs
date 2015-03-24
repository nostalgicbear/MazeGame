using UnityEngine;
using System.Collections;

public class displayGUI : MonoBehaviour {

	private bool drawPrompt;
	public GUIText doorPrompt;

	void Start()
	{
		Screen.showCursor = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "door")
		{
			drawPrompt = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "door")
		{
			drawPrompt = false;
		}
	}
	
	void Update()
	{

		if(drawPrompt == true)
		{
			doorPrompt.enabled = true;
		}
		else{
			doorPrompt.enabled = false;
		}
	}
}
