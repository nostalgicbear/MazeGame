using UnityEngine;
using System.Collections;

public class FindPlayer : MonoBehaviour {
	private NavMeshAgent navMesh;
	private GameObject player;
	private Animator anim;
	private RaycastHit hit;
	private bool increaseFear = false;
	private float playerFear;
	public GUIText playerFearGUI;
	public AudioClip intenseAudio;
	private AudioSource audio;


	// Use this for initialization
	void Start () {
		navMesh = GetComponent<NavMeshAgent>();
		player = GameObject.Find("First Person Controller");
		anim = GetComponent<Animator>();
		playerFear = 0.0f;
		audio = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(transform.position, player.transform.position);
		
			navMesh.SetDestination(player.transform.position);

		Vector3 enemyFieldOfView = player.transform.position - transform.position;
		Vector3 raycastStartPosition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
		if(Physics.Raycast(raycastStartPosition, enemyFieldOfView, out hit))
		{
			if(hit.collider.gameObject.tag == "Player")
			{
				if(distance <= 40)
				{
					increaseFear = true;
					audio.mute = false;
				}


			}
		}


		Debug.DrawRay(raycastStartPosition, enemyFieldOfView, Color.red);

		if(increaseFear)
		{
			playerFear += 0.08f;
		}

		if(distance > 40)
		{
			increaseFear = false;
			playerFear -= 0.02f;
			audio.mute = true;
		}

		if(playerFear >= 100)
		{
			Application.LoadLevel("EndScreen");
		}

		if(playerFear <= 0)
		{
			playerFear = 0;
		}

		playerFearGUI.guiText.text = playerFear.ToString("f1");
	
	}
	


}
