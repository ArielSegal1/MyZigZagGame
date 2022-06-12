using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField]
    Button restartButton;

    [SerializeField]

    Button menuButton;

    [SerializeField]
    Rigidbody player;

    [HideInInspector]
    public bool isGameOver = false;

    public void EndGame(){
        player.gameObject.SetActive(false);
         isGameOver = true;
        Restart();
    }

    void Restart(){
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
    }
}
