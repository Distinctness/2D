using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ( "Pick Up"))
		{
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Cubes Collected: " + count.ToString ();
		if (count >= 10)
		{
			winText.text = "You Win!";
			GetComponent<Animator> ().enabled = true;
		}
	}
}