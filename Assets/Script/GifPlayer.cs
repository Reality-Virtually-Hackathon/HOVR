using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifPlayer : MonoBehaviour {

    public Sprite[] gif;
	public Image displayImage;
	public bool cycling = false;


	// Use this for initialization
	void Start () {
        gif = new Sprite[138];
		for (int i = 0; i < 137; i++) {
			if (i < 10) {
				gif [i] = Resources.Load ("Gif/instructions_0000" + i + ".png") as Sprite;
			} else if (i < 100) {
				gif [i] = Resources.Load ("Gif/instructions_000" + i + ".png") as Sprite;
			} else {
				gif [i] = Resources.Load ("Gif/instructions_00" + i + ".png") as Sprite;
			}
			
		}

		
	}

    IEnumerator playGif()
    {
        for(int i = 0; i<=137; i++)
        {
	        displayImage.GetComponent<Image>().sprite = gif[i];
            yield return new WaitForSeconds(0.04f);
        }

    }

    private void OnEnable()
    {
		playGif ();
    }

	private void OnDisable()
	{
		cycling = false;
	}

    // Update is called once per frame
    void Update () {
//		if (cycling) {
//			playGif ();
//		}
	}
}
