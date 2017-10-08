using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {

	public GameObject turnsOn;
	public GameObject turnsOff;

	void OnCollisionEnter(Collision collision){
		turnsOff.SetActive (false);
		turnsOn.SetActive (true);
	}

}
