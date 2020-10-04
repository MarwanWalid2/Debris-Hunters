using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float jumpForce = 10f;
	private AudioSource audioSource;
    public AudioClip jump;

void Start() {
	GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = jump;
}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				audioSource = GetComponent<AudioSource>();
            audioSource.clip = jump;
            audioSource.Play();

				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}
	}

}
