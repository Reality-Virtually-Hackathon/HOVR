using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats {

	public float points;
	public float distanceTraveled;
	List<float> sessionVelocities;
	GameObject scripts;
	GameObject playerBase;

	// Use this for initialization
	void Start () {
		sessionVelocities = new List<float> ();
		scripts = GameObject.Find (GameObjectNameConstants.ScriptsObject);
		playerBase = GameObject.Find (GameObjectNameConstants.PlayerBaseName);
	}
	
	// Update is called once per frame
	void Update () {
		//Get current velocity and save it to the list
		float currentVelocity = playerBase.GetComponent<Rigidbody>().velocity.x; //TODO: verify what the forward velocity is
		sessionVelocities.Add(currentVelocity);

	}

	void loadPlayerData (){
		//Called at the beginning of main menu load. Pulls data from playerprefs into some sort of display?
		//TODO: Load past player data and stats from playerprefs



	}

	void saveSessionData (){
		//Called at the end of a play session. Saves the statistics from the current play session to playerprefs.
		//Turn the session data into a json string 
		//Call a playerprefs.setstring



	}

}
