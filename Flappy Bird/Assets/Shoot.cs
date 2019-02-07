using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Rigidbody bulletPrefab;
	public Transform gunBarrel;
	public int bulletForce = 1500;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Rigidbody bullet = Instantiate (bulletPrefab, gunBarrel.position, gunBarrel.rotation) as Rigidbody;
			bullet.AddForce (gunBarrel.forward * bulletForce);
		}
	}
}
