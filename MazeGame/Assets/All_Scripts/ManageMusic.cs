using UnityEngine;
using System.Collections;

public class ManageMusic : MonoBehaviour {
	AudioSource music;

	// Use this for initialization
	void Start () {
		music = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.M))
		{
			music.mute = !music.mute;
		}
	
	}
}
