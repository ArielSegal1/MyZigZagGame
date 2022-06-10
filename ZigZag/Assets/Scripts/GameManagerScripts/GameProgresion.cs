using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgresion : MonoBehaviour
{
    CoinCollector coinCollector;
    
     [SerializeField]
    GameObject player;

    CharacterMoveMent speed;

    private void Start() {
        coinCollector = player.GetComponent<CoinCollector>();
        speed = player.GetComponent<CharacterMoveMent>();
    }
    private void Update() {
        if(coinCollector.points >= 20 && coinCollector.points < 50){
            speed.speed = 4.5f;
        }
        else if(coinCollector.points >= 50 && coinCollector.points <= 100){
            speed.speed = 5;
        }
    }
}
