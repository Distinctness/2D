using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Transform ShootArea;
	public GameObject bullet;
	float ShootTimer;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ShootTimer += Time.fixedDeltaTime;
		if (ShootTimer >= 1){
			ShootTimer = 0;
			GameObject bill = GameObject.Instantiate (bullet,ShootArea.position,ShootArea.rotation);
			bill.GetComponent<Rigidbody2D> ().AddForce (transform.right * speed,ForceMode2D.Impulse);
			}
	}
}
