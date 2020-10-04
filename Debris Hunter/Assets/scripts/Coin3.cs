using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin3 : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
	{
		GameControlScript.moneyAmount += 3;
		Destroy (gameObject);
	}
}
