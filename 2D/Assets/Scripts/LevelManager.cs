using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	private float health = 100f;					// The player's health.
	private SpriteRenderer healthBar;			// Reference to the sprite renderer of the health bar.
	private PlayerControl player;
	private Vector3 healthScale;				// The local scale of the health bar initially (with full health).
	private PlayerControl playerControl;		// Reference to the PlayerControl script.
	private Animator anim;						// Reference to the Animator on the player

	void Awake ()
	{
		// Setting up references.
		playerControl = GetComponent<PlayerControl>();
		healthBar = GameObject.Find("HealthBar").GetComponent<SpriteRenderer>();
		//anim = GetComponent<Animator>();

		// Getting the intial scale of the healthbar (whilst the player has full health).
		healthScale = healthBar.transform.localScale;
	}

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl>();
	}

	// Update is called once per frame
	void Update () {
	}

	public void RespawnPlayer()
	{
		Debug.Log ("Player Respawn");
		//player.transform.position = currentCheckpoint.transform.position;
		player.transform.position = new Vector3 (currentCheckpoint.transform.position.x, currentCheckpoint.transform.position.y + 5, player.transform.position.z);
		Heal();
		// Update what the health bar looks like.
		UpdateHealthBar();
	}
	public void Heal()
	{
		health = 100f;

		// Increase the player's health by the health bonus but clamp it at 100.
		//health = Mathf.Clamp(health, 0f, 100f);

	}

	public void UpdateHealthBar ()
	{
		// Set the health bar's colour to proportion of the way between green and red based on the player's health.
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);

		// Set the scale of the health bar to be proportional to the player's health.
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
	}
}