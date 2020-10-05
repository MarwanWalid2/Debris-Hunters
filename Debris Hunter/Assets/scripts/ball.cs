using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
     public Canvas canvas;
 
    public float Speed = 7f;
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left*Speed*Time.deltaTime);

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
