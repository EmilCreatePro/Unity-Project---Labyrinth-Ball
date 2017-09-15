using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour 
{

	public GameObject confirm, credits;

	void Start()
	{
		confirm.SetActive (false);
		credits.SetActive (false);
	}

	public void PlayOption(string levelName)
	{
		GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene (levelName);
	}

	public void CreditsOpt()
	{
		GetComponent<AudioSource> ().Play ();
		credits.SetActive (true);

	}

	public void quitOpt()
	{
		GetComponent<AudioSource> ().Play ();
		confirm.SetActive (true);
	}

	public void YesOpt()
	{
		GetComponent<AudioSource> ().Play ();
		Application.Quit ();
	}

	public void NoOpt()
	{
		GetComponent<AudioSource> ().Play ();
		confirm.SetActive (false);
	}

	public void BackOpt()
	{
		GetComponent<AudioSource> ().Play ();
		credits.SetActive (false);
	}

}
