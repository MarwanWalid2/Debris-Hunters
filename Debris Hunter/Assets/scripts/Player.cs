using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float movementSpeed = 10f;

	public Canvas canvas;
	//ublic GameControlScript gameControlScript;
	Rigidbody2D rb;

	float movement = 0f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
		// check for collision
     
	}

     private void OnCollisionEnter2D(Collision2D other) {
         
         if (other.gameObject.CompareTag("Coins"))
         {
             Destroy(other.gameObject);
         }
     }

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	
	}
	
	void OnBecameInvisible() {
        // Destroy(gameObject);
		 
		// gameControlScript.gotoShop();

		canvas.gameObject.SetActive(true);
     }

	  
}
