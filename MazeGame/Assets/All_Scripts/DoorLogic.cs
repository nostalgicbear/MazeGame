using UnityEngine;
using System.Collections;

public class DoorLogic : MonoBehaviour {

	private bool drawPrompt;
	public GUIText doorPrompt;
	private bool doorIsClosed = true;
	public Transform theDoor;
	public AudioClip doorSound;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			drawPrompt = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
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

		if(drawPrompt == true && Input.GetMouseButtonDown(0))
		{
			Debug.Log("In the loop");
			StartCoroutine(changeDoorState());
			//changeDoorState();
	}
	}

	IEnumerator changeDoorState()
	{
		Debug.Log("In the changeDoorState loop");
		if(doorIsClosed == true)
		{
			audio.PlayOneShot(doorSound, 0.9f);
			theDoor.animation.CrossFade("rotateDoor");
			//theDoor.audio.PlayOneShot();
			doorIsClosed = false;
			yield return new WaitForSeconds(3);
			theDoor.animation.Stop("rotateDoor");
			theDoor.animation.CrossFade("closeDoor");
			doorIsClosed = true;
		}
	}
	
}
