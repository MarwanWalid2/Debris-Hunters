using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
     public Canvas canvas;
    public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 5f;
	public float maxYB = 5f;
    public float Speed = 7f;
    float playerPos;
    [SerializeField]
	Transform rotationCenter;

	[SerializeField]
	float rotationRadius = 2f, angularSpeed = 2f;

	float posX, posY, angle = 0f;

    
    // Update is called once per frame
    void Update()
    {
        //playerPos = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        //Debug.Log (playerPos);
       // rotationRadius = Random.Range(playerPos ,playerPos+10) ;
        posX = rotationCenter.position.x + Mathf.Cos (angle) * rotationRadius;
		posY = rotationCenter.position.y + Mathf.Sin (angle) * -rotationRadius * 2;
		//transform.position = new Vector2 (posX, posY);
		angle = angle + Time.deltaTime * angularSpeed;

		if (angle >= 360f)
			angle = 0f;
        
        transform.Translate(new Vector2 (posX, posY)*Speed*Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D other)
     {
         //Check if the object has the tag car

         if(other.tag == "Player")
         {
             //Activate the canvas
             canvas.gameObject.SetActive(true);
         }
     }

}
