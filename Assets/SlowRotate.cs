using UnityEngine;
using System.Collections;

public class SlowRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.down * 0.05f);
	}
}
