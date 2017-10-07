using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalMovementManager : MonoBehaviour {

	public GameObject pedalTrackerLeft, pedalTrackerRight;
	public GameObject playerBase;

    float totalDistanceTraveled;
	Vector3 previousLoc;
	float pedalDistanceVelocityMultiplier = 1.0f;

	// Use this for initialization
	void Start () {
		
		if (pedalTrackerLeft != null && pedalTrackerRight != null) {
			previousLoc = pedalTrackerLeft.transform.localPosition;
		} else {
			Debug.Log ("PedalMovementManager Initializiation Error: Could not find pedal tracker");
		}

    }

	
	// Update is called once per frame
	void Update () {

        float tickDistanceTraveled = 0.0f;

        Vector3 currentLoc = pedalTrackerLeft.transform.localPosition;
        tickDistanceTraveled = Vector3.Distance(previousLoc, currentLoc);
        totalDistanceTraveled += tickDistanceTraveled;

        Vector3 playerMovement = playerBase.transform.forward * tickDistanceTraveled;

        if (tickDistanceTraveled > 0.01f)
        {
            playerBase.GetComponent<PlayerMovement>().AddVelocity(playerMovement * pedalDistanceVelocityMultiplier);
        }

        previousLoc = currentLoc;

    }
}
