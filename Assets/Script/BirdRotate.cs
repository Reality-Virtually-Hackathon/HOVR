using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRotate : MonoBehaviour {

    float speed = 50f;
    bool flying = false;
	private Component[] birds;
	// Use this for initialization
	void Start () {
		birds = GetComponentsInChildren<BirdController>();
	}

    void OnTriggerEnter(Collider other)
    {
        flying = true;
        Debug.Log("Hit birds");
		foreach (BirdController bird in birds) {
			bird.startFlying ();
		}
    }


    // Update is called once per frame
    void Update () {
        
		if (flying) {
			//transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y + 0.01f, transform.localPosition.z);
		} else {
			transform.Rotate(Vector3.up, speed * Time.deltaTime);
		}
    }
}
