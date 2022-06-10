using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HideOnStart : MonoBehaviour
{   
    [SerializeField]
    Button restartButton;

    private void Awake() {
        restartButton.gameObject.SetActive(false);    
    }
}
