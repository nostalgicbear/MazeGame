using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {
	public int wayPointCounter;
	
	public int rayLength = 10;
	
	void Start()
	{
		wayPointCounter = 1;
		float time = 0;
	}
	
	void Update()
	{
		GameObject target = GameObject.Find("Wp" + wayPointCounter);
		transform.LookAt(target.transform);

		if(Vector3.Distance(gameObject.transform.position, target.transform.position) < 2)
		{
			wayPointCounter++;
		}
		
		if(wayPointCounter > 6)
		{
			wayPointCounter=1;
		}
		
		transform.Translate(Vector3.forward * Time.deltaTime*5);
		
		RaycastHit hit;
		Vector3 fwd = transform.forward;
		Debug.DrawRay(transform.position, fwd * rayLength);
		
		if(Physics.Raycast(transform.position, fwd,out hit, rayLength))
		{
			if(hit.collider.gameObject.tag == "Waypoint")
			{
				transform.rotation = Quaternion.Lerp(target.transform.rotation, transform.rotation, 50.0f);
			}
		}
		
	}
	
	
}





