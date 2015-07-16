using UnityEngine;
using System.Collections;

public class GrappleBeam : MonoBehaviour {

	TractorBeam magnet;

	// Use this for initialization
	void Start () {
		magnet = transform.FindChild ("Magnet").GetComponent<TractorBeam>();
		retract ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void retract(){
		gameObject.SetActive (false);
		magnet.clamped = false;
//		int children = transform.childCount;
//		for (int i = 1; i < children; i++) {
//			transform.GetChild(i).position = transform.GetChild(0).position;
//		}
	}

	public void extend(){
		gameObject.SetActive (true);
//		int children = transform.childCount;
//		for (int i = 1; i < children; i++) {
//			transform.GetChild(i).GetComponent<Rigidbody>().AddForce(Vector3.down, ForceMode.Impulse);
//		}
	}
}
