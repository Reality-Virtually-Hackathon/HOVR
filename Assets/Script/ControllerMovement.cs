using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		ScreenBlanker = GameObject.Find (GameObjectNameConstants.ScreenBlanker);
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
			StartCoroutine (ScreenBlack ());
            direction = trackedObj.transform.forward;
            //Debug.Log(gameObject.name + " Trigger Press");
            direction = new Vector3(direction.x, 0, direction.z);
            playerBase.transform.rotation = Quaternion.LookRotation(direction);
			StartCoroutine (ScreenLight ());
        }
    }

    IEnumerator ScreenBlack()
    {

        for(int i = 0; i<=225; i+=25)
        {
			Color temp = ScreenBlanker.GetComponent<Image>().color;
			temp.a = i;
			ScreenBlanker.GetComponent<Image>().color = temp;
        	yield return true;
        }

    }

	IEnumerator ScreenLight()
	{

		for(int i = 225; i>=0; i-=25)
		{
			Color temp = ScreenBlanker.GetComponent<Image>().color;
			temp.a = i;
			ScreenBlanker.GetComponent<Image>().color = temp;
			yield return true;
		}

	}
}
