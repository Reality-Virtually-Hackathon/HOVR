using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalMovementManager : MonoBehaviour {

	public GameObject pedalTracker;
	public GameObject playerBase;
	float totalDistanceTraveled;
	Vector3 previousLoc;

	float pedalDistanceVelocityMultiplier = 1.0f;

	// Use this for initialization
	void Start () {
		if (pedalTracker != null) {
			previousLoc = pedalTracker.transform.localPosition;
		} else {
			Debug.Log ("PedalMovementManager Initializiation Error: Could not find pedal tracker");
		}
	}
	
	// Update is called once per frame
	void Update () {
		float tickDistanceTraveled = 0.0f;

		Vector3 currentLoc = pedalTracker.transform.localPosition;
		tickDistanceTraveled = Vector3.Distance (previousLoc, currentLoc);
		totalDistanceTraveled += tickDistanceTraveled;

		//TODO: Apply force to player and increase velocity
		Vector3 playerForward = playerBase.transform.forward; //This may not work, may need Camera.forward

		GameObject.Find (GameObjectNameConstants.PlayerBaseName).GetComponent<PlayerMovement> ().AddVelocity (playerForward * pedalDistanceVelocityMultiplier);

	}
}
