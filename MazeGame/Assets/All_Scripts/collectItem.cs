using UnityEngine;
using System.Collections;

public class collectItem : MonoBehaviour {

	public GUIText scoreText;

	public GUITexture guiTexture1;
	public GUITexture guiTexture2;
	public GUITexture guiTexture3;
	public GUITexture guiTexture4;
	public GUITexture guiTexture5;
	public int score;

	public AudioClip collectableSound;

	void Start()
	{
		score = 0;
	}
	

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "collectable")
		{
			Destroy(collider.gameObject);
			audio.PlayOneShot(collectableSound);
			score+=10;
			scoreText.text = "Score: " + score;
		}
	}

	void Update()
	{
		if(score == 10)
		{
			guiTexture1.enabled = true;
		}

		if(score == 20)
		{
			guiTexture2.enabled = true;
		}
		if(score == 30)
		{
			guiTexture3.enabled = true;
		}
		if(score == 40)
		{
			guiTexture4.enabled = true;
		}
		if(score == 50)
		{
			guiTexture5.enabled = true;
		}
	}
}
