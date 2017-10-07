using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnPath : MonoBehaviour {

	GameObject visionFader;
	float visionBlockerLevel = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CheckPosition ()) {
			visionBlockerLevel = 0f;	
		} else {
			visionBlockerLevel += 0.1f;
		}

	}

	//Check if the player is currently within the approved area
	bool CheckPosition(){
		

	}
}
