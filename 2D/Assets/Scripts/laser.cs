using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {
	public Transform laserStart;
	public GameObject SecondLaser;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit;
		float laserLength;
		hit = Physics2D.Raycast (laserStart.position,laserStart.transform.right,100);
		if (hit.collider == null) {
			laserLength = 100;
		} else {
			laserLength = hit.distance;
			if (laserLength > 100){
				laserLength = 100;
			}
		}
		transform.localScale = new Vector3 (laserLength * 10, 10, 1);
		if (hit.transform != null && hit.transform.tag == "Reflector") {
			SecondLaser.SetActive (true);

			RaycastHit2D hit2;
			float laserLength2;
			Vector2 ReflectDir = Vector2.Reflect (transform.right,hit.normal);
			hit2 = Physics2D.Raycast (hit.point,ReflectDir,100);
			if (hit2.collider == null) {
				laserLength2 = 100;
			} else {
				laserLength2 = hit2.distance;
				if (laserLength2 > 100){
					laserLength2 = 100;
				}
			}
			SecondLaser.transform.right = ReflectDir;
			SecondLaser.transform.localScale = new Vector3 (laserLength2 * 10, 20, 1);
			SecondLaser.transform.position = hit.point;

		} else {
			SecondLaser.SetActive (false);
		}
		//transform.localPosition = new Vector3 (laserLength * 0.5f, transform.localPosition.y, transform.localPosition.z);
	}
}
