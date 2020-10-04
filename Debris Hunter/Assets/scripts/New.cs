using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class New : MonoBehaviour
{
    public Canvas canvas;
    public void Info()
	{
		canvas.gameObject.SetActive(true);
	}

    public void newGame()
	{
		PlayerPrefs.DeleteAll ();
        SceneManager.LoadScene ("Main");
	}

    public void Close()
	{
		canvas.gameObject.SetActive(false);
	}
}
