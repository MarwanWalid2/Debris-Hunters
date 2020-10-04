using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoint : MonoBehaviour
{
    public Canvas canvas;
    private AudioSource audioSource;
    public AudioClip check;
    public Text moneyText;
	public static int moneyAmount;
    public static int newmoneyAmount = 0;

	// Use this for initialization
	
	// Update is called once per frame
    
void Start() {
    GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = check;
}

     void OnCollisionEnter2D(Collision2D collision)
	{
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = check;
            audioSource.Play();
		   // PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
             canvas.gameObject.SetActive(true);
             GameObject.Find("GameControl").GetComponent<GameControlScript>().saveDebris();
             //GameObject.Find("ScoreManager").GetComponent<noMoney>().CollisionDetected(this);
            //moneyText.text =  newmoneyAmount.ToString() ;
             
	}

    
}
