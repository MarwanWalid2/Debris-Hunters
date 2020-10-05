using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
public GameObject asteroidPrefab;
    public float minSpawnTime = 3.0f;
     public float maxSpawnTime = 5.0f;
     public float distFromCamera = 10.0f;
 
     private float timer = 0.0f;
     private float nextTime;
         
     void Start () {
         nextTime = Random.Range(minSpawnTime, maxSpawnTime);    
     }
     
     void Update () {
         timer += Time.deltaTime;
         
         if (timer > nextTime) {
             Vector3 pos = new Vector3(0, Random.value, distFromCamera);
             pos = Camera.main.ViewportToWorldPoint(pos);
 
             Instantiate(asteroidPrefab, pos, Quaternion.identity);
             
            
             
             timer = 0.0f;
             nextTime = Random.Range(minSpawnTime, maxSpawnTime);
         }
     }
 }