using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartsMovement : MonoBehaviour
{

    public float speed = 300f;
    public Rigidbody2D rb;
    public int damage = 50;

    public AudioSource FiredAudio;
    //public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;

            //if (FiredAudio == null){
            FiredAudio = GetComponent<AudioSource>();
            //}
    }

   private void OnTriggerEnter2D(Collider2D hitInfo)
    {

     BalloonHealth dart = hitInfo.GetComponent<BalloonHealth>();
        if(dart != null) {
            dart.TakeDamage(damage);
            //AudioSource.PlayClipAtPoint(audio.clip, transform.position);
           
 
            //dart.TakeDamage(damage,isSpecialBullet);
            //Destroy(gameObject);
            //dart.enemyHitAudio(isSpecialBullet);
            //dart.enemyDeathAudio(isSpecialBullet);
            
        Destroy(gameObject);
        }
    }
}
	
/*
    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.up * speed;

    }


    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        BalloonHealth dart = hitInfo.GetComponent<BalloonHealth>();
        if(dart != null) 
        {
            dart.TakeDamage(damage);
            //AudioSource.PlayClipAtPoint(audio.clip, transform.position);
           
            Destroy(gameObject);
           
        }

    }

} */