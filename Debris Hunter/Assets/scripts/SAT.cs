using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAT : MonoBehaviour
{
   public Canvas canvas;
    // Start is called before the first frame update
    bool isPaused = false; 
    void OnTriggerEnter2D(Collider2D other)
     {
         //Check if the object has the tag car

         if(other.tag == "Player")
         {
             Pause();
             canvas.gameObject.SetActive(true);
         }
     }
     
public void Pause()
	{
		if (isPaused){

            Time.timeScale = 1;
            isPaused = false;
        } else
        {
            
            Time.timeScale = 0;
            isPaused = true;
        }
	}
     public void Close()
	{
		canvas.gameObject.SetActive(false);
	}
}
