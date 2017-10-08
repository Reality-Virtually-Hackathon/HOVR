using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifPlayer : MonoBehaviour {

    public Sprite[] gif;
	public Image displayImage;
	public int curr = 0;
	public bool cycling = false;


	// Use this for initialization
	void Start () {

		
	}

    //IEnumerator playGif()
    //{
    //    for(int i = 0; i<=137; i++)
    //    {
    //        GetComponent<Image>().sprite =
    //        yield return new WaitForSeconds(0.04f);
    //    }

    //}

    private void OnEnable()
    {
		cycling = true;
    }

	private void OnDisable()
	{
		cycling = false;
	}

    // Update is called once per frame
    void Update () {
		if (cycling) {
			
		}
	}
}
