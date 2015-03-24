using UnityEngine;
using System.Collections;

public class moveWheelChair : MonoBehaviour {

	public Transform targetPosition;
	public float speed;
	public GameObject player;


	// Update is called once per frame
	void Update () {
		//Debug.Log("Distance is :" + Vector3.Distance(player.transform.position, transform.position));
		if(Vector3.Distance(player.transform.position, transform.position) < 40)
		{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, step);
		}
	
	}
}
