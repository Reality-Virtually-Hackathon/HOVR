using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalMovementManager : MonoBehaviour {

	public GameObject pedalTrackerLeft, pedalTrackerRight;
	public GameObject playerBase;

    private SteamVR_TrackedObject lHandController, rHandController;

    private SteamVR_Controller.Device LController
    {
        get { return SteamVR_Controller.Input((int)lHandController.index); }
    }
    private SteamVR_Controller.Device RController
    {
        get { return SteamVR_Controller.Input((int)rHandController.index); }
    }

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

    void Awake()
    {
        GameObject b = GameObject.Find(GameObjectNameConstants.PlayerBaseName);
        GameObject lH = b.transform.Find("Controller (left)").gameObject;
        Debug.Log(lH);

        lHandController = GameObject.Find(GameObjectNameConstants.LeftController).GetComponent<SteamVR_TrackedObject>();
        rHandController = GameObject.Find(GameObjectNameConstants.RightController).GetComponent<SteamVR_TrackedObject>();
    }

    void CheckSteps()
    {
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

    void CheckTurning()
    {
        if (LController.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " LTrigger Press");
        }
        if (RController.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " RTrigger Press");
        }
    }
	
	// Update is called once per frame
	void Update () {

        CheckSteps();
        CheckTurning();


	}
}
