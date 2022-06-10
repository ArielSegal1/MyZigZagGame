using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinCollector : MonoBehaviour
{

    
    public int points = 0;
    private void OnCollisionEnter(Collision other) {
        Renderer otherRend = other.gameObject.GetComponent<Renderer>();
        if(other.gameObject.tag == "Coin")
        {
            if(String.Equals(otherRend.material.color.ToString(), Color.red.ToString())){
                points += 5;
            }
            else{
                points++;
            }
            FindObjectOfType<AudioManager>().Play("collectcoin");
            Destroy(other.gameObject);
            
        }
    }

}
