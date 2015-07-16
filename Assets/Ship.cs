using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float fuel;
	public float speed;
	public float rotateSpeed;
	Rigidbody2D rigidBody;
	GameObject exhaust;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		exhaust = transform.GetChild (0).gameObject;
		exhaust.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			thrust ();
			exhaust.SetActive(true);
		} else {
			exhaust.SetActive(false);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			rotateShip(1);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			rotateShip(-1);
		}
	}

	public void thrust(){
		if(fuel > 0.0f){
			rigidBody.AddForce(transform.up * speed, ForceMode2D.Force);
			fuel -= Time.deltaTime * 100;
		}
	}

	public void rotateShip(int dir){
		transform.Rotate (Vector3.forward * dir * rotateSpeed);
	}
}
