using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {

	public GameObject turnsOn;
	public GameObject turnsOff;
	AudioSource pingSource;
	AudioClip ping;

	void Start(){
		pingSource = new AudioSource();
		ping = Resources.LoadAsync ("ping") as AudioClip;
	}

	void OnCollisionEnter(Collision collision){
		try{
			turnsOff.SetActive (false);
			turnsOn.SetActive (true);
		}
		catch(Exception e){
		}
		pingSource.PlayOneShot (ping);
		Destroy (this.gameObject);
	}

}
