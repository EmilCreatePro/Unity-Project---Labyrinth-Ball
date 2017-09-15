using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	private Vector3 offset;

	public GameObject player;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () //it's better with LateUpdate because the information is updated at the end of the frame 
	{
		transform.position = player.transform.position + offset;
	}
}
