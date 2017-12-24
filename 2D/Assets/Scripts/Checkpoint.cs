using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public LevelManager levelManager;

	//Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}

	//Update is called once per frame
	void Update () {
	}

	//void OnTriggerEnter2D(Collider2D other)
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			levelManager.currentCheckpoint = gameObject;
			Debug.Log ("Activated Checkpoint " + transform.position);
		}
	}
}
