using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class noMoney : MonoBehaviour
{
   public Text moneyText;
	public static int moneyAmount;

	public static int money;
	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text =  moneyAmount.ToString() + "$";
		money = GameControlScript.newmoneyAmount;
	}

	public void toShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", money );
		SceneManager.LoadScene ("Untitled");
	}
	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", money);
		SceneManager.LoadScene ("Main");
	}
}
