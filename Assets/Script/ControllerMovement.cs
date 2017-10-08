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

        if (Controller.GetHairTriggerDown())
        {
            this.gameObject.transform.Find(GameObjectNameConstants.ArrowMesh).GetComponent<MeshRenderer>().enabled = true;

        }

        if (Controller.GetHairTriggerUp())
        {
            this.gameObject.transform.Find(GameObjectNameConstants.ArrowMesh).GetComponent<MeshRenderer>().enabled = false;
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

        for(float i = 0f; i<=1; i+=0.1f)
        {
			Color temp = ScreenBlanker.GetComponent<Image>().color;
			temp.a = i;
			ScreenBlanker.GetComponent<Image>().color = temp;
			yield return new WaitForSeconds(0.035f);
        }
        yield return new WaitForSeconds(0.11f);

    }

	IEnumerator ScreenLight()
	{

		for(float i = 1f; i>=0; i-=0.1f)
		{
			Color temp = ScreenBlanker.GetComponent<Image>().color;
			temp.a = i;
			ScreenBlanker.GetComponent<Image>().color = temp;
			yield return new WaitForSeconds(0.035f);
		}

	}
}
