using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRotate : MonoBehaviour {

    float speed = 50f;
    bool flying = false;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        flying = true;
        Debug.Log("Hit birds");
    }


    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        if (flying)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.01f, transform.localPosition.z);
        }
    }
}
