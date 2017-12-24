using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {
	public float time;
	// Use this for initialization
	void Start () {
		GameObject.Destroy (gameObject,time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
