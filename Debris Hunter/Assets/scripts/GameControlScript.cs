using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {

	public Text moneyText;
	public static int moneyAmount;
	int isSkinSold;
	public GameObject rifle;
	int isSkin2Sold;
	public GameObject rifle2;
	int isSkin3Sold;
	public GameObject rifle3;
	int isSkin4Sold;
	public GameObject rifle4;
	public static int newmoneyAmount;
	//public int newmoneyAmount = 0;

	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		isSkinSold = PlayerPrefs.GetInt ("IsSkinSold");
		isSkin2Sold = PlayerPrefs.GetInt ("IsSkin2Sold");
		isSkin3Sold = PlayerPrefs.GetInt ("IsSkin3Sold");
		isSkin3Sold = PlayerPrefs.GetInt ("IsSkin4Sold");


		if (isSkin4Sold == 1)
			rifle4.SetActive (true); 
		else
			rifle4.SetActive (false);

		if (isSkin3Sold == 1)
			rifle3.SetActive (true); 
		else
			rifle3.SetActive (false);

		if (isSkin2Sold == 1)
			rifle2.SetActive (true); 
		else
			rifle2.SetActive (false);
			
		if (isSkinSold == 1)
			rifle.SetActive (true);
		else
			rifle.SetActive (false);

		
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text =  moneyAmount.ToString() + "$";
	}

	public void gotoShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("Untitled");
	}

	

	public void saveDebris()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		 newmoneyAmount = moneyAmount;
		//Debug.Log(newmoneyAmount);
		//moneyText.text =  newmoneyAmount.ToString() + "$";
		//SceneManager.LoadScene ("Untitled");
	}
}
