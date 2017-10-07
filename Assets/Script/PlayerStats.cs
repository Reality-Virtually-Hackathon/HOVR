using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats {

	public float points;
	List<float> sessionVelocities;
	GameObject scripts;

	// Use this for initialization
	void Start () {
		sessionVelocities = new List<float> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void loadPlayerData (){
		//Called at the beginning of main menu load. Pulls data from playerprefs into some sort of display?
		//TODO: Load past player data and stats from playerprefs

	}

	void saveSessionData (){
		//Called at the end of a play session. Saves the statistics from the current play session to playerprefs.
	}

}
