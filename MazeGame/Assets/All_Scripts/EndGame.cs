using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	public GUIText hintText;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			if(GameObject.Find("First Person Controller").GetComponent<collectItem>().score >= 50)
			{
				Application.LoadLevel("YouWin");
			}

			else{
				hintText.guiText.enabled = true;
				hintText.guiText.text = "You need to find a total of 5 hearts before you can leave";
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			hintText.guiText.enabled = false;
			hintText.guiText.text = "";
		}
	}
}
