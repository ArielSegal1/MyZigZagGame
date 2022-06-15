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
    Text highScoreText;

    [SerializeField]
    Rigidbody player;

    [SerializeField]

    CoinCollector points;

    [HideInInspector]
    public bool isGameOver = false;




    private void Start() {
          if (!PlayerPrefs.HasKey("HighScore"))
     {
         PlayerPrefs.SetInt("HighScore", 0);
     }
    }

    public void EndGame(){
        player.gameObject.SetActive(false);
        isGameOver = true;
        if(points.points > PlayerPrefs.GetInt("HighScore", points.points)){
        PlayerPrefs.SetInt("HighScore", points.points);
        PlayerPrefs.Save();
        }
        StartCoroutine(WaitBeforeAd());
        //SavePlayer();
        Restart();
    }

    void Restart(){
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        highScoreText.gameObject.SetActive(true);

    }

    public IEnumerator WaitBeforeAd()
    {
        yield return new WaitForSeconds(0.15f);
         if(Random.Range(0,3) == 1){
        FindObjectOfType<InterstitialAdsButton>().ShowAd();
        }
    }
/*
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(FindObjectOfType<CoinCollector>());
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        FindObjectOfType<CoinCollector>().points = data.score;
    }*/
}
