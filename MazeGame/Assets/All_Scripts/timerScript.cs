using UnityEngine;
using System.Collections;

public class timerScript : MonoBehaviour {
	
	public GUIText timeGUI;
	private float minute;
	private float second;
	private Color color;

	void Start()
	{
		minute = 10;
		second = 59;
	}

	// Update is called once per frame
	void Update () {

		timeGUI.text = "Time Left:" + Mathf.Round(minute) + ":" + Mathf.Round(second);

		second-=Time.deltaTime;
		if(second <0)
		{
			second = 59;
			minute-=1;;
		}

		if(minute<=0 && second <=59)
		{
			timeGUI.color = Color.red;
		}

		if(minute<=0 && second <=1)
		{
			Application.LoadLevel("EndScreen");
		}

	}
	
}
