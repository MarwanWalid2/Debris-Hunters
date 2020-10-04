using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject platformPrefab;

	public GameObject checkPrefab;
	public GameObject finalPrefab;
	public GameObject SAT1;
	public GameObject SAT2;
	public GameObject SAT3;
	public int numberOfPlatforms = 200;
	public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 5f;
	public float maxYB = 5f;

	public GameObject coinPrefab;
	public GameObject coin2Prefab;
	public GameObject coin3Prefab;

	public int numberOfCoins = 300;

	// Use this for initialization
	void Start () {

		Vector3 coinSpawnPosition = new Vector3();

		for (int i = 0; i < numberOfCoins; i++)
		{
			coinSpawnPosition.y += Random.Range(minY, maxYB);
			coinSpawnPosition.x = Random.Range(-levelWidth - 2 , levelWidth);
			Instantiate(coinPrefab, coinSpawnPosition, Quaternion.identity);
			coinSpawnPosition.y += Random.Range(minY, maxYB);
			coinSpawnPosition.x = Random.Range(-levelWidth - 2 , levelWidth);
			Instantiate(coin2Prefab, coinSpawnPosition, Quaternion.identity);
			coinSpawnPosition.y += Random.Range(minY, maxYB);
			coinSpawnPosition.x = Random.Range(-levelWidth - 2 , levelWidth);
			Instantiate(coin3Prefab, coinSpawnPosition, Quaternion.identity);
		}

		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth - 2, levelWidth);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			
			if (i == 490)
			{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth - 2, levelWidth);
			Instantiate(finalPrefab, spawnPosition, Quaternion.identity);
			}

			if (i == 10 || i == 20|| i == 50 || i == 75|| i == 100 || i == 150|| i == 200 || i == 250|| i == 300 || i == 350|| i == 450 || i == 600|| i == 650 || i == 700|| i == 750 | i == 800|| i == 850 || i == 900|| i == 950)
			{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(checkPrefab, spawnPosition, Quaternion.identity);
			}  

			if (i == 150)
			{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(SAT1, spawnPosition, Quaternion.identity);
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth - 2, levelWidth);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			}  
			if (i == 300)
			{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(SAT2, spawnPosition, Quaternion.identity);
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth - 2, levelWidth);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			}  
			if (i == 450)
			{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(SAT3, spawnPosition, Quaternion.identity);
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth - 2, levelWidth);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			}  


			

		}

		
	}
}
