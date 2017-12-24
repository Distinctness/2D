using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotKeyRespawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			SceneManager.LoadScene ("Test");
			// ... reload the level.
			//StartCoroutine("ReloadGame");
		}	
	}
IEnumerator ReloadGame()
{			
	// ... pause briefly
	yield return new WaitForSeconds(2);
	// ... and then reload the level.
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
}
}