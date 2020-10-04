using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin2 : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col)
	{
		GameControlScript.moneyAmount += 2;
		Destroy (gameObject);
	}
}

