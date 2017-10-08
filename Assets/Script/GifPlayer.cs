using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifPlayer : MonoBehaviour {

    Sprite[] gif;

	// Use this for initialization
	void Start () {
        gif = new Sprite[138];

        
		
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
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
