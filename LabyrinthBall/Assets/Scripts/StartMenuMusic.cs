using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuMusic : MonoBehaviour 
{

	public Camera cam;

	// Use this for initialization
	void Start () 
	{
		GetComponent<AudioSource> ().Play();
	}

	void Update() 
	{
		cam.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
	}
		
}
