using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouchingTotem : MonoBehaviour {

	// Getting the scriptmanager
	public GameObject scriptManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//  Method for collision
	void OnTriggerEnter(Collider col)
	{
		// if the name of the collided gameobject is Button1 the following happens
		if(col.gameObject.name == "Button1"){
			// Goes to scriptmanager, finds the TotemAnsweringMethod script, find the sign1 bool, and turns it true
			scriptManager.GetComponent<TotemAnsweringMethod>().sign1 = true;
			print("HIT");
		}

		if(col.gameObject.name == "Button2"){
			scriptManager.GetComponent<TotemAnsweringMethod>().sign2 = true;
		}

		if(col.gameObject.name == "Button3"){
			scriptManager.GetComponent<TotemAnsweringMethod>().sign3 = true;
		}

		if(col.gameObject.name == "Button4"){
			scriptManager.GetComponent<TotemAnsweringMethod>().sign4 = true;
		}
	}
}
