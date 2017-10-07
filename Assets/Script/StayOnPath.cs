using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnPath : MonoBehaviour {

	//Accessed, and set true or false by script attached to boundaries of path
	public bool onPath;
	GameObject visionFader;
	float visionBlockerLevel = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (onPath){
			visionBlockerLevel = 0f;	
		} else {
			visionBlockerLevel += 0.1f;
		}

	}
}
