using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

	private Rigidbody rb;
	private int count;

	public GameObject player;
	public bool isFlat = true;
	public float speed;
	public Text countText;
	public Text winText;

	public int fuck;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();

		winText.text = "";
		SetText ();
		count = 0;
	}
		
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			//Debug.Log ("The back button has been pressed!");
			SceneManager.LoadScene("StartMenu");
		}

		Vector3 temp = new Vector3(player.transform.position.x, 0.5f, player.transform.position.z);
		player.transform.position = temp;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//Vector3 tilt = Input.acceleration;
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 move = new Vector3 (moveHorizontal, 0, moveVertical);


		//if (isFlat)
			//tilt = Quaternion.Euler (90, 0, 0) * tilt * fuck;

		//rb.AddForce (tilt * speed);
		//rb.velocity = tilt * speed;

		float moveHori = Input.GetAxis ("Horizontal");
		float moveVert = Input.GetAxis ("Vertical");

		Vector3 misc = new Vector3 (moveHori, 0.0f, moveVert);

		rb.AddForce (misc * fuck);

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			GetComponent<AudioSource> ().Play ();
			SetText ();
		}
	}

	void SetText()
	{
		countText.text = "Points: " + count.ToString ();

		if (count == 34) 
			{
				winText.text = "You Win!"; 
			}
	}
		
}
