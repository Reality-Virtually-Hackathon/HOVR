using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {

	public GameObject turnsOn;
	public GameObject turnsOff;
	AudioSource pingSource;
	AudioClip ping;

	void Start(){
		pingSource = new AudioSource();
		ping = Resources.Load("ping") as AudioClip;
	}

	void OnTriggerEnter(Collider collider){
		try{
			turnsOff.SetActive (false);
			turnsOn.SetActive (true);
		}
		catch(Exception e){
		}
        GetComponent<AudioSource>().Play();
	}

}
