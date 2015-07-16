using UnityEngine;
using System.Collections;

public class TractorBeam : MonoBehaviour {

	//GameObject beam;
	//GameObject magnet;
	public bool clamped = false;
	GameObject cargo;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (clamped) {
			cargo.transform.position = Vector3.Lerp(cargo.transform.position, transform.position, Time.deltaTime * 3.0f);
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Cargo" && !clamped){
			clamped = true;
			cargo = other.gameObject;
			cargo.GetComponent<FixedJoint>().connectedBody = transform.GetComponent<Rigidbody>();
		}
	}
}
