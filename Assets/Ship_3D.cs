using UnityEngine;
using System.Collections;

public class Ship_3D : MonoBehaviour {

	public float thrustSpeed;
	public float rotateSpeed;
	public float fuel;

	Rigidbody shipHull;
	GrappleBeam grapple;

	// Use this for initialization
	void Start () {
		shipHull = GetComponent<Rigidbody> ();
		grapple = transform.GetChild (0).GetComponent<GrappleBeam> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			thrust();
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			rotateShip(-1);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			rotateShip(1);
		}

		if (Input.GetKeyDown (KeyCode.B)) {
			grapple.extend();
		}

		if(Input.GetKeyDown(KeyCode.H)){
			grapple.retract();
		}


	}

	public void thrust(){
		if(fuel > 0){
			shipHull.AddForce (transform.forward * thrustSpeed, ForceMode.Force);
			fuel -= Time.deltaTime;
		}
	}

	public void rotateShip(int dir){
		transform.Rotate (Vector3.up * dir * rotateSpeed);
	}


}
