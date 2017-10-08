using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        //Trigger sound
        GetComponent<AudioSource>().Play();
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<SphereCollider>().enabled = false;
    }
}
