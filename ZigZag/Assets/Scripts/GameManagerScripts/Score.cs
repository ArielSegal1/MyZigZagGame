using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    CoinCollector coinCollector;
    [SerializeField]
    GameObject player;

    [SerializeField]
    Text scoreText;
    private void Awake() {
        coinCollector = player.GetComponent<CoinCollector>();
    }

    private void Start() {
        
    }

    void Update()
    {
            scoreText.text = coinCollector.points.ToString() + " POINTS";   
    }
}
