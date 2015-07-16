using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	GameObject ship;
	Text fuelGauge;

	// Use this for initialization
	void Start () {
		ship = GameObject.Find("Ship_3D");
		fuelGauge = GameObject.Find("FuelGauge").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
//		if(!ship && GameObject.Find("Ship_3D")){
//			ship = GameObject.Find("Ship_3D");
//			fuelGauge = GameObject.Find("FuelGauge").GetComponent<Text>();
//		}

		if (fuelGauge) {
			fuelGauge.text = "Fuel: " + ship.GetComponent<Ship_3D>().fuel.ToString("F0");
		}
	}
}
