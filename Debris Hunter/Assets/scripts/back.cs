using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{

    public Canvas canvas;
    // Start is called before the first frame update
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
