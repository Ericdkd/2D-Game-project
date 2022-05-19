using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts : MonoBehaviour
{

	public Transform firePoint;
	[SerializeField] GameObject dartsPreFab;
	public AudioSource FiredAudio;
	

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
	{
            //if (FiredAudio == null){
				//FiredAudio = GetComponent<AudioSource>();
            //}
		Shoot();
	}

    }
	
	void Shoot()
	{
if (FiredAudio == null){
	FiredAudio = GetComponent<AudioSource>();
}
	GameObject dart = Instantiate(dartsPreFab, firePoint.position, firePoint.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
	//Destroy(dart, 0.5f);
	}

}
