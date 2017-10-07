using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathBoundary : MonoBehaviour {

	GameObject PlayerBase;


	void Start(){
		PlayerBase = GameObject.Find (GameObjectNameConstants.PlayerBaseName);
	}

	//This script is attached to objects that form the boundaries of the path

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "player") {
			PlayerBase.GetComponent<StayOnPath> ().onPath = false;
		}
	}

	void OnCollisionExit(Collision collision){
		if (collision.gameObject.tag == "player") {
			PlayerBase.GetComponent<StayOnPath> ().onPath = true;
		}
	}
}
