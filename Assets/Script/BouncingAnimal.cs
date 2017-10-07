using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingAnimal : MonoBehaviour {

	GameObject Smoke;

	void Start(){
		Smoke = Resources.Load("WhiteSmoke") as GameObject;
		this.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 1);
	}

//	void Start(){
//		StartCoroutine (RightMotion());
//		Debug.Log ("rightmotion done");
//		StartCoroutine (LeftMotion());
//		Debug.Log ("leftmotion done");
//	}
//
//	IEnumerator RightMotion(){
//		for (float i = this.gameObject.transform.rotation.z; i < 60; i++) {
//			Vector3 rotation = this.gameObject.transform.rotation.eulerAngles;	
//			this.gameObject.transform.rotation = Quaternion.Euler (new Vector3 (rotation.x, rotation.y, i));
//			Debug.Log ("rightmoved");
//			yield return true;
//		}
//	}
//
//	IEnumerator LeftMotion(){
//		for (float j = this.gameObject.transform.rotation.z; j > -60; j--) {
//			Vector3 rotation = this.gameObject.transform.rotation.eulerAngles;	
//			this.gameObject.transform.rotation = Quaternion.Euler (new Vector3 (rotation.x, rotation.y, j));
//			Debug.Log ("leftmoved");
//			yield return true;
//		}

	void OnCollisionEnter(Collision collision){
		Debug.Log ("Collided with duck");
		Instantiate (Smoke, this.transform);
		Destroy (this);
	}

}
