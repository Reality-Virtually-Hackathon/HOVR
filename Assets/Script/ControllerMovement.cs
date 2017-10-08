using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {

    private GameObject playerBase;
    private GameObject ScreenBlanker;
    private Vector3 direction;

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }



    private void Start()
    {
        playerBase = GameObject.Find(GameObjectNameConstants.PlayerBaseName);
    }


    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        Debug.Assert(trackedObj != null);
    }

    // Update is called once per frame
    private void Update () {

        if (Controller.GetHairTriggerUp())
        {
            direction = trackedObj.transform.forward;
            //Debug.Log(gameObject.name + " Trigger Press");
            direction = new Vector3(direction.x, 0, direction.z);
            playerBase.transform.rotation = Quaternion.LookRotation(direction);
            
        }
    }

    IEnumerator BlinkScreen()
    {

        for(int i = 0; i<1; i++)
        {
            
        }

        yield return true;
    }


}
