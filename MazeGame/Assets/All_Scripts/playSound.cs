using UnityEngine;
using System.Collections;

public class playSound : MonoBehaviour {

	public AudioClip footsteps;
	private bool isMoving = false;



	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
		{
			if(!audio.isPlaying)
			{
				audio.loop = true;
				audio.Play();
			}
		}
		else{
			audio.Stop();
		}

	
	}
}
