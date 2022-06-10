using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallingDeath : MonoBehaviour
{
    public Rigidbody rb;
    public float positionDeath = 0.8f;

    void Update()
    {
        if(rb.position.y < positionDeath){
            FindObjectOfType<GameOver>().EndGame();   
    }
    }
   
    
}
