using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	private bool flying = false;
	private Vector3 dir;
	private float speed = 5f;

	// Use this for initialization
	void Start () {
		dir = new Vector3(Random.Range(0f, 10.0f), Random.Range(0f, 10.0f), 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (flying) {
			transform.rotation = Quaternion.LookRotation (dir);
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}


	}

	public void startFlying() {
		flying = true;
	}

}
