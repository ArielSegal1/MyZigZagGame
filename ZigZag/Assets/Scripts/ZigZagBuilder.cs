using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagBuilder : MonoBehaviour
{
    
    private List<GameObject> Tiles;
    [SerializeField]
    private GameObject TilePrefab;
    [SerializeField]
    private GameObject character;
    [SerializeField]
    private GameObject CoinPrefab;
    private Vector3 nextDirection = Vector3.right;
    private int scoreThreshold = 100;

    private float after100PointsPrefabScale = 0.65f;

    private float after100PointsPrefabPosition = 0.35f;

    private int after100PointsCount = 0;

    Color newColor;
    CoinCollector points;
    void Start()
    {
        points = character.GetComponent<CoinCollector>();
        Tiles = new List<GameObject>() {Instantiate(TilePrefab, new Vector3(3,0,2), Quaternion.identity)};
        Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = Color.grey;
        for(int i = 0; i < 49; i++){
            AddNewTile();
        }
    }

    private void AddNewTile() // Tile adding
    {
       
        nextDirection = (Random.Range(0,2) == 1 ? Vector3.right : Vector3.forward);
        if(Tiles.Count < 50)
        {
            Tiles.Add(Instantiate(TilePrefab, Tiles[Tiles.Count - 1].transform.position + nextDirection, Quaternion.identity));
            Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = Color.grey;
            //Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = newColor;
        }
        else
        {
            if(points.points >= 20 && points.points < 50){
                Tiles[0].transform.localScale = new Vector3(0.85f,1,0.85f);
                Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = Color.green;
                if(nextDirection == Vector3.right){
                    Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection - new Vector3(0.15f,0,0);
                }else{
                    Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection - new Vector3(0,0,0.15f);
                }
                //Tiles[0].GetComponent<MeshRenderer>().material.color = newColor;
                Tiles.Add(Tiles[0]);
               
                Tiles.RemoveAt(0);
            }
            else if(points.points >= 50 && points.points <= 100){
                Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = Color.red;
                Tiles[0].transform.localScale = new Vector3(0.7f,1,0.7f);
                if(nextDirection == Vector3.right){
                    Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection - new Vector3(0.3f,0,0);
                }else{
                    Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection - new Vector3(0,0,0.3f);
                }
                //Tiles[0].GetComponent<MeshRenderer>().material.color = newColor;
                Tiles.Add(Tiles[0]);
               
                Tiles.RemoveAt(0);
            }
            else if(points.points > 100){
                if(Random.Range(1,10) == 3){
                Instantiate(CoinPrefab, Tiles[Tiles.Count - 1].transform.position + new Vector3(0,1,0), Quaternion.identity);
            }
        if(Random.Range(1,50) == 10){
            GameObject bigCoin = Instantiate(CoinPrefab, Tiles[Tiles.Count - 1].transform.position + new Vector3(0,1,0), Quaternion.identity);
            Renderer rend = bigCoin.GetComponent<Renderer>();
            rend.material.color = Color.red;
            
        }
                if(points.points > scoreThreshold){
                    if(after100PointsCount == Tiles.Count){
                        if(after100PointsPrefabScale > 0.35f){
                after100PointsPrefabScale -= 0.05f;
                after100PointsPrefabPosition = 1f - after100PointsPrefabScale;
                scoreThreshold += 10;
                newColor = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f)); // Select random color
                after100PointsCount = 0;
                for(int i = 0; i < 10;i++){
                Tiles.Add(Instantiate(TilePrefab, Tiles[Tiles.Count - 1].transform.position + new Vector3(1,0,0) - new Vector3(after100PointsPrefabPosition,0,0), Quaternion.identity));
                Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = newColor;
                Tiles[Tiles.Count-1].transform.localScale = new Vector3(after100PointsPrefabScale,1,after100PointsPrefabScale);
                }
                        }
                   } 
                }
                After100Points(newColor);
                
                                
            }
            else
            {
                Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection;
                Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = Color.grey;
                //Tiles[0].GetComponent<MeshRenderer>().material.color = newColor;
                Tiles.Add(Tiles[0]);
                Tiles.RemoveAt(0);
            }
        
        }
        if(points.points < 100){
        if(Random.Range(1,5) == 3){
                Instantiate(CoinPrefab, Tiles[Tiles.Count - 1].transform.position + new Vector3(0,1,0), Quaternion.identity);
            }
        if(Random.Range(1,21) == 10){
            GameObject bigCoin = Instantiate(CoinPrefab, Tiles[Tiles.Count - 1].transform.position + new Vector3(0,1,0), Quaternion.identity);
            Renderer rend = bigCoin.GetComponent<Renderer>();
            rend.material.color = Color.red;
            
        }
        }
    }
    

    void Update(){
        if(Vector3.Distance(character.transform.position, Tiles[(Tiles.Count-1)/2].transform.position)<2)
        {
            AddNewTile();
        }
        
    }

    void After100Points(Color newColor){
                after100PointsCount++;
                //Tiles[Tiles.Count-1].GetComponent<MeshRenderer>().material.color = newColor;
                Tiles[0].transform.localScale = new Vector3(after100PointsPrefabScale,1,after100PointsPrefabScale);
                if(nextDirection == Vector3.right){
                    Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection - new Vector3(after100PointsPrefabPosition,0,0);
                }else{
                    Tiles[0].transform.position = Tiles[Tiles.Count-1].transform.position + nextDirection - new Vector3(0,0,after100PointsPrefabPosition);
                }
                Tiles[0].GetComponent<MeshRenderer>().material.color = newColor;
                
                Tiles.Add(Tiles[0]);
               
                Tiles.RemoveAt(0);

                
                
    }

}
