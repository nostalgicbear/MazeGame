using UnityEngine;
using System.Collections;

public class openDoors : MonoBehaviour {

	private bool isOpen = false;

	// Use this for initialization
	void Start () {

		isOpen = false;
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "door")
		{
			other.gameObject.animation.animation.Play("doorOpening");
			Debug.Log("Player in range");
		}
	}
}
