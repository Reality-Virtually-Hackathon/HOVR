using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	GameObject PlayerBase;
	Rigidbody rb;
	float frictionConstant = 1.0f;

	// Use this for initialization
	void Start () {
		PlayerBase = GameObject.Find (GameObjectNameConstants.PlayerBaseName);
		rb = PlayerBase.GetComponent<Rigidbody> ();
		Debug.Assert (rb != null);
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity -= new Vector3(frictionConstant, frictionConstant, frictionConstant);
	}

	public void AddVelocity (Vector3 velocityToAdd){
		rb.velocity += velocityToAdd;
	}

	float getVelocity(){
		return rb.velocity.x;
	}

}
