using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class KillPlayer : MonoBehaviour
{
	//public GameObject splash;
	private LevelManager levelManager;

	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col)
	{		
		if (col.tag == "Player")
			levelManager.RespawnPlayer ();
		else if (col.tag == "Enemy")
			col.GetComponent<Enemy> ().Death ();

		}
	}
