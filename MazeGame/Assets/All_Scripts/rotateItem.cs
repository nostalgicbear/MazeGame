using UnityEngine;
using System.Collections;

public class rotateItem : MonoBehaviour {

	public float speed = 100;
	

	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.up, Time.deltaTime * speed);
	
	}
}
