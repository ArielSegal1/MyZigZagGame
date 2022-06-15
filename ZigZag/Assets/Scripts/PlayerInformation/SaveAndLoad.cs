/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
   
   private void Awake() {
    LoadGame();
   }
   private void Update() {
        if(FindObjectOfType<GameOver>().isGameOver){
            SaveGame();
        }
   }

   private void SaveGame()
   {
    PlayerData playerData = new PlayerData();
    playerData.score = FindObjectOfType<CoinCollector>().points;
    SaveSystem.SavePlayer(playerData);
   }

   private void LoadGame()
   {
        PlayerData playerData = SaveSystem.LoadPlayer();
        if(playerData != null){
            FindObjectOfType<CoinCollector>().points = playerData.score;        
        }
   }
}
*/