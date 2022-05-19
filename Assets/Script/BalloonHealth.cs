using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonHealth : MonoBehaviour{
	
	public float maxSize = 0.1f;
	public float growthRate = 0.1f;
	public float scale = 0.1f;
	public GameObject NextSceneButton;
	public AudioSource DeathAudio;
	public float healthAmount;
	public GameObject balloon2;
	 public GameObject Player;
   
    void Start() {
	balloon2 = GameObject.FindGameObjectWithTag("balloon2");
        healthAmount = 100;
	if(balloon2 != null)
	{
	healthAmount = 100;
	}
    }
    void Update(){
	
	transform.localScale = Vector3.one * scale;
	scale += growthRate * Time.deltaTime;
	if (scale > maxSize)
	{
	Destroy(gameObject);
	}

        if(healthAmount <= 0){
	Pop();
	}
    }

	void OnTriggerEnter2D(Collider2D col){
	if(col.gameObject.name.Equals("SquareDart"))
		healthAmount -= 1;
	}
	public void TakeDamage (int damage){
		healthAmount -= damage;
		if(healthAmount <= 0){
			Pop();
			if(DeathAudio == null)
			DeathAudio = GetComponent<AudioSource>();
			AudioSource.PlayClipAtPoint(DeathAudio.clip, transform.position);
			Player.GetComponent<scores>().IncrementScore();

		}
	}
	public void Pop(){
		
		Destroy(gameObject);

		NextSceneButton.gameObject.SetActive(true);
		//FiredAudio = GetComponent<AudioSource>();
	}

}