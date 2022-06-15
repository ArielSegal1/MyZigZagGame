using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveMent : MonoBehaviour
{
    Vector3 movementVector = Vector3.right;

    public float speed;

    public GameObject gameManager;
    private GameOver checkGameOver;



    private void Start() {
        checkGameOver = gameManager.GetComponent<GameOver>();
    }
    void Update()
    {
        if(!checkGameOver.isGameOver){
        if(Input.GetMouseButtonDown(0)){
            FindObjectOfType<AudioManager>().Play("click");
            if(movementVector == Vector3.right){
                movementVector = Vector3.forward;
            }
            else
            {
                movementVector = Vector3.right;
            }
        }
        transform.position = transform.position+movementVector*speed*Time.deltaTime;
            }
    }

}
