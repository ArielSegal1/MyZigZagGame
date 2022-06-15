using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HideOnStart : MonoBehaviour
{   
    [SerializeField]
    Button restartButton;

    [SerializeField]
    Button menuButton;

    [SerializeField]

    Text highScoreText;

    private void Awake() {
        restartButton.gameObject.SetActive(false);    
        menuButton.gameObject.SetActive(false);
        highScoreText.gameObject.SetActive(false);
    }
}
