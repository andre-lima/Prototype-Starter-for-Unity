﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	public void PlayButton ()
    {
        LoadingScreenManager.LoadScene(2);
    }
	
}
