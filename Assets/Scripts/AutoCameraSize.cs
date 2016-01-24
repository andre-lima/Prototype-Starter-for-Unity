using UnityEngine;
using System.Collections;

public class AutoCameraSize : MonoBehaviour {

    private Camera thisCamera;

    void Start () {

       thisCamera = gameObject.GetComponent<Camera>();

        if (thisCamera.orthographic)
        {
            //Maintains the Aspect Ration in the Horizontal axis.
            thisCamera.orthographicSize = 8.889f * Screen.height / Screen.width;
        }
        else
        {
            Debug.Log("This camera is NOT ortographic: " + thisCamera);
        }
	}

}
