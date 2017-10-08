using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        //Trigger sound
        GetComponent<AudioSource>().Play();
        Destroy(this.gameObject);
    }
}
