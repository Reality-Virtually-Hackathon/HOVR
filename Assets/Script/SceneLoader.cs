﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour {

	public void StartSession(){
		//Float out UI, initialize variables 

		//Load the content scene asynchronously
		SceneManager.LoadSceneAsync (1);

	}

}
