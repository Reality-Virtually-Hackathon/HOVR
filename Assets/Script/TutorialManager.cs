using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {

	public GameObject turnsOn;
	public GameObject turnsOff;

	void OnCollisionEnter(Collision collision){
		try{
			turnsOff.SetActive (false);
			turnsOn.SetActive (true);
		}
		catch(Exception e){
		}
		Destroy (this.gameObject);
	}

}
