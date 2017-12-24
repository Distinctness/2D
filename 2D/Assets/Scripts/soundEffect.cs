using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffect : MonoBehaviour {
	public GameObject soundObject;
	// Use this for initialization
	void Start () {
		GameObject.Instantiate (soundObject,transform.position,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
