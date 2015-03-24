using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {
	private float timer = 25.0f;
	private Color color;

	// Use this for initialization
	void Start () {
		color = renderer.material.color;
		color.a = 1.0f;
		renderer.material.color = color;
		MouseLook ml = GameObject.Find("First Person Controller").GetComponent<MouseLook>();
		ml.enabled = false;
		FPSInputController inputController = GameObject.Find("First Person Controller").GetComponent<FPSInputController>();
		inputController.enabled = false;
		MouseLook mainCamera = GameObject.Find("Main Camera").GetComponent<MouseLook>();
		mainCamera.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer - Time.deltaTime;

		if(timer >=0 && timer < 5.0f)
		{
			color.a -= 0.1f * Time.deltaTime;
			renderer.material.color = color;
		}

		if(timer<=0)
		{
			timer = 0;
			GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLook>().enabled = true;
			GameObject.FindGameObjectWithTag("Player").GetComponent<FPSInputController>().enabled = true;
			GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
			//Destroy(gameObject);
			gameObject.renderer.enabled=false;
		}
	}
}
