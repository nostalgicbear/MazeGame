using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("test worked");
		}
	}
}
