using UnityEngine;
using System.Collections;

public class MoveToCar : MonoBehaviour {
	public int wayPointCounter;
	
	void Start()
	{
		wayPointCounter = 1;
	}
	
	void Update()
	{
		GameObject target = GameObject.Find("Wp" + wayPointCounter);
		transform.LookAt(target.transform);
		
		if(Vector3.Distance(gameObject.transform.position, target.transform.position) > 2)
		{
			transform.Translate(Vector3.forward * Time.deltaTime*3);
		}
		else{

		}
		
	}
	
	
}





