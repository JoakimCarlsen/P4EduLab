﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsHit : MonoBehaviour {

	public GameObject[] fruits;								// apples, pears and bananas

	public GameObject cube;
	public GameObject stoneBowl;
	public GameObject ImageTarget2;

	//	AudioSource AppleHitSoundFX;
	int rememberFruit;										// creates integer used as a temporary varible to remember which fruit was taken

//	-------------------------------- Winning State
	int appleScore = 2;										// integers give each fruit a value that will be used in the winning state. The numbers are chosen specifically 
	int bananaScore = 1;									// to make sure that there are only certain possibilities to answer correct.
	int pearScore = 5;
	int scoreCount;

	bool isDragged = false;									// boolean to make sure that only one apple at a time can be moved
	public bool [] fruitDone;								// boolean array to know when the fruit is in the bowl




	//	bool getPoint = false;											// Score system (NEED FIX)



	// Use this for initialization
	void Start () {
		for (int i = 0; i < fruitDone.Length; i++) {				// assign booleans in array with a true value
//			fruitReady [i] = true;
			fruitDone [i] = false;
		}



		cube = GameObject.Find ("Camera");

		stoneBowl = GameObject.Find ("StoneBowl");

		ImageTarget2 = GameObject.Find ("ImageTarget2");

		//		AppleHitSoundFX = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

		//	----------------------------------Winning State
		if (scoreCount == 3) {
			
		}

	}

	void OnTriggerEnter(Collider col) {

		for (int i = 0; i < fruits.Length; i++) {
			if (col.gameObject.name == ("fruit" + i) && isDragged == false && fruitDone[i] == false) { 		//&& fruitDone[i] == false	&& fruitReady[i] == true && fruitDone == false		forloop used to go through 
				fruits[i].transform.parent = cube.transform;

				if (i <= 2) {
					fruits[i].transform.localPosition = new Vector3(0.004f, -0.04f, 0.35f);
					fruits[i].transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
				} else {
					fruits[i].transform.localPosition = new Vector3(0.004f, -0.01f, 0.2f);
					fruits[i].transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
				}
				rememberFruit = i;
				isDragged = true;

				//			AppleHitSoundFX.Play (); 		
			}


			if (col.gameObject.name == ("StoneBowl") && fruitDone[rememberFruit] == false) {
				print ("basketIsHit");
				isDragged = false;
				fruits[rememberFruit].transform.parent = ImageTarget2.transform;
				fruitDone [rememberFruit] = true;

				if (rememberFruit <= 2) {			// positions for bananas
					if (rememberFruit == 0) {
						fruits[rememberFruit].transform.localPosition = new Vector3(0f , 0.03f, -0.08f);			
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-8.8f , 74f, 137f);
						fruits[rememberFruit].transform.localScale = new Vector3 (5f, 5f, 5f);
						scoreCount += bananaScore;
					}

					if (rememberFruit == 1) {
						fruits[rememberFruit].transform.localPosition = new Vector3(0.04f , 0.03f, -0.01f);			
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-22f , 55f, 473f);
						fruits[rememberFruit].transform.localScale = new Vector3 (5f, 5f, 5f);
						scoreCount += bananaScore;
					}
					if (rememberFruit == 2) {
						fruits[rememberFruit].transform.localPosition = new Vector3(-0.11f , 0.04f, 0.04f);			
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(0.2f , 61f, 232f);
						fruits[rememberFruit].transform.localScale = new Vector3 (5f, 5f, 5f);
						scoreCount += bananaScore;
					}
				}
				if (rememberFruit >= 3 && rememberFruit <= 5) {		// positions for apples
					if (rememberFruit == 3) {
						fruits[rememberFruit].transform.localPosition = new Vector3(-0.05f , 0.05f, -0.02f);
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-15f , 16f, 4f);
						fruits[rememberFruit].transform.localScale = new Vector3 (6f, 6f, 6f);
						scoreCount += appleScore;
					}

					if (rememberFruit == 4) {
						fruits[rememberFruit].transform.localPosition = new Vector3(0.1f , 0.08f, 0.11f);
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-34f , 17.5f, -15.7f);
						fruits[rememberFruit].transform.localScale = new Vector3 (6f, 6f, 6f);
						scoreCount += appleScore;
					}

					if (rememberFruit == 5) {
						fruits[rememberFruit].transform.localPosition = new Vector3(0f , 0.1f, -0.12f);
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-161f , 8f, 4f);
						fruits[rememberFruit].transform.localScale = new Vector3 (6f, 6f, 6f);
						scoreCount += appleScore;
					}
				}
				if (rememberFruit >= 6 && rememberFruit <= 8) { 	// positions for pears
					if (rememberFruit == 6) {
						fruits[rememberFruit].transform.localPosition = new Vector3(0.02f , 0.08f, 0.04f);
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-18.4f , 24f, -150f);
						fruits[rememberFruit].transform.localScale = new Vector3 (6f, 6f, 6f);
						scoreCount += pearScore;
					}

					if (rememberFruit == 7) {
						fruits[rememberFruit].transform.localPosition = new Vector3(-0.1f , 0.08f, -0.1f);
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-8.8f , -23f, -44f);
						fruits[rememberFruit].transform.localScale = new Vector3 (6f, 6f, 6f);
						scoreCount += pearScore;
					}

					if (rememberFruit == 8) {
						fruits[rememberFruit].transform.localPosition = new Vector3(-0.1f , 0.08f, 0.1f);
						fruits[rememberFruit].transform.localRotation = Quaternion.Euler(-5.2f , 42.3f, -15.4f);
						fruits[rememberFruit].transform.localScale = new Vector3 (6f, 6f, 6f);
						scoreCount += pearScore;
					}
			
				}

				print ("score is " + scoreCount);

			}
		}
	}
		

}

//	void OnGUI() {
//		if (getPoint == true) {	
//			GUIStyle style = new GUIStyle();
//			style.fontSize = 80;
//			GUI.color = Color.yellow;
//			GUI.Label (new Rect (Screen.width/2-25, Screen.height/2-50, 100, 100), ""+scoreCount, style);
//		}
//	}
//}
