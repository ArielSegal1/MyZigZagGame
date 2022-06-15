using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallingDeath : MonoBehaviour
{
    public Rigidbody rb;
    public float positionDeath = 0.8f;

    private bool onceParticle = true;

    [SerializeField] GameObject deathVFX;

    void Update()
    {
        if(rb.position.y < positionDeath){
            if(onceParticle){
            FindObjectOfType<AudioManager>().Play("explosionDeath");
            GameObject explostion = Instantiate(deathVFX, transform.position, transform.rotation);
            Destroy(explostion, 0.75f); 
            onceParticle = false;
            }
            FindObjectOfType<GameOver>().EndGame();   
    }
    }
   
    
}
