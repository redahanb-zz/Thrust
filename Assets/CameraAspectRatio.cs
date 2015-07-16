using UnityEngine;
using System.Collections;

public class CameraAspectRatio : MonoBehaviour {

	Camera mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = GetComponent<Camera> ();
		//mainCamera.ResetAspect ();
		//mainCamera.aspect = Screen.width / Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		mainCamera.ResetAspect ();
		//mainCamera.aspect = Screen.width / Screen.height;
	}
}
