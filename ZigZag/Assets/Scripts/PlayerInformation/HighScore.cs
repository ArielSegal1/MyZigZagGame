using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    [SerializeField]
    Text highScoreText;

  
    
    

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = "HIGH SCORE\n" + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
