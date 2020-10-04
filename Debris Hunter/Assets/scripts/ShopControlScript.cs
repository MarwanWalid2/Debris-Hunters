using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isSkinSold;

	private AudioSource audioSource;
    public AudioClip buy;

	public Text moneyAmountText;
	public Text riflePrice;

	public Button buyButton;
	public Button buy2Button;
	public Button buy3Button;
	public Button buy4Button;

		
		int isSkin2Sold;
		public Text rifle2Price;
		int isSkin3Sold;
		public Text rifle3Price;
		int isSkin4Sold;
		public Text rifle4Price;
		
	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = buy;
	}
	
	// Update is called once per frame
	void Update () {
		
		moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

		isSkin4Sold = PlayerPrefs.GetInt ("IsSkin4Sold");

		if (moneyAmount >= 100 && isSkin4Sold == 0)
			buy4Button.interactable = true;
		else
			buy4Button.interactable = false;

		isSkin3Sold = PlayerPrefs.GetInt ("IsSkin3Sold");

		if (moneyAmount >= 15 && isSkin3Sold == 0)
			buy3Button.interactable = true;
		else
			buy3Button.interactable = false;

		isSkin2Sold = PlayerPrefs.GetInt ("IsSkin2Sold");

		if (moneyAmount >= 10 && isSkin2Sold == 0)
			buy2Button.interactable = true;
		else
			buy2Button.interactable = false;

		isSkinSold = PlayerPrefs.GetInt ("IsSkinSold");

		if (moneyAmount >= 5 && isSkinSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;	

		
	}

	

	public void buySkin()
	{
		moneyAmount -= 5;
		audioSource = GetComponent<AudioSource>();
            audioSource.clip = buy;
            audioSource.Play();
		PlayerPrefs.SetInt ("IsSkinSold", 1);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}
	
	public void buy2Skin()
	{
		moneyAmount -= 10;
		audioSource = GetComponent<AudioSource>();
            audioSource.clip = buy;
            audioSource.Play();
		PlayerPrefs.SetInt ("IsSkin2Sold", 1);
		rifle2Price.text = "Sold!";
		buy2Button.gameObject.SetActive (false);
	}

	public void buy3Skin()
	{
		moneyAmount -= 15;
			audioSource = GetComponent<AudioSource>();
            audioSource.clip = buy;
            audioSource.Play();
		PlayerPrefs.SetInt ("IsSkin3Sold", 1);
		rifle3Price.text = "Sold!";
		buy3Button.gameObject.SetActive (false);
	}

	public void buy4Skin()
	{
		moneyAmount -= 100;
			audioSource = GetComponent<AudioSource>();
            audioSource.clip = buy;
            audioSource.Play();
		PlayerPrefs.SetInt ("IsSkin4Sold", 1);
		rifle4Price.text = "Sold!";
		buy4Button.gameObject.SetActive (false);
	}

	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("Main");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		riflePrice.text = "Price: 5$";
		rifle2Price.text = "Price: 10$";
		rifle3Price.text = "Price: 15$";
		rifle4Price.text = "Price: 100$";
		PlayerPrefs.DeleteAll ();
	}

}
