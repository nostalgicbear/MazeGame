using UnityEngine;
using System.Collections;

public class openElevatorDoor : MonoBehaviour {
	GameObject doorLeft;
	GameObject doorRight;

	// Use this for initialization
	void Start () {
		doorLeft = GameObject.Find("elevatorDoorLeft");
		doorRight = GameObject.Find("elevatorDoorRight");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "elevatorDoor")
		{

			doorLeft.animation.wrapMode = WrapMode.Once;
			doorLeft.animation.CrossFade("openElevator");
			doorRight.animation.wrapMode = WrapMode.Once;
			doorRight.animation.CrossFade("openElevatorRight");
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "elevatorDoor")
		{
			other.gameObject.collider.enabled = false;
		}
	}
}
