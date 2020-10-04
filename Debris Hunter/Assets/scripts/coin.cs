using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject Coin;
    public int coinValue = 1;

    private  void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }

}
  
        
    
