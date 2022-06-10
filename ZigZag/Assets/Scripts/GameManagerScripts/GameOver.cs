using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField]
    Button restartButton;

    [SerializeField]
    Rigidbody player;

    [HideInInspector]
    public bool isGameOver = false;

    public void EndGame(){
         player.velocity = Vector3.zero;
         player.angularVelocity = Vector3.zero;
         isGameOver = true;
        Restart();
    }

    void Restart(){
        restartButton.gameObject.SetActive(true);
    }
}
