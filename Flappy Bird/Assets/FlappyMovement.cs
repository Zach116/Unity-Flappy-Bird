using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMovement : MonoBehaviour {
	public float moveSpeed = 10f;
	public float upForce = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Forward ();
		if (Input.GetKeyDown (KeyCode.Space)) {
			(GetComponent <Rigidbody>()).velocity = new Vector3 (0, upForce, 0);
		}
	}

	void Forward ()
	{
		transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
	}
}
