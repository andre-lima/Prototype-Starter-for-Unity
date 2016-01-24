using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	public void PlayButton ()
    {
        LoadingScreenManager.LoadScene(2);
        SceneManager.LoadScene(1);
    }
	
}
