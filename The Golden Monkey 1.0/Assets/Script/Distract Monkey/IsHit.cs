using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsHit : MonoBehaviour {

	public GameObject[] fruits;
//	------------------------------ apple
//	public GameObject apple;
//	------------------------------ banana
//	public GameObject banana;
//	------------------------------ pear
//	public GameObject pear;

	public GameObject cube;
	public GameObject basket;

	public GameObject ImageTarget2;

	AudioSource AppleHitSoundFX;


	bool isDragged = false;									// boolean to make sure that only one apple at a time can be moved

	public bool [] fruitReady;
	public bool [] fruitDone;

//	bool apple1Ready = false;
//	bool apple2Ready = false;
//	bool apple3Ready = false;
//	bool apple1Done = false;
//	bool apple2Done = false;
//	bool apple3Done = false;

//	bool getPoint = false;											// Score system (NEED FIX)
//	int scoreCount;


	// Use this for initialization
	void Start () {

		for (int i = 0; i < fruitReady.Length; i++) {				// assign booleans in array with a false value
			fruitReady [i] = false;
		}
			


		cube = GameObject.Find ("Camera");

		basket = GameObject.Find ("Basket");

		ImageTarget2 = GameObject.Find ("ImageTarget2");

		AppleHitSoundFX = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		
		for (int i = 0; i < fruits.Length; i++) {
			if (col.gameObject.name == ("fruit" + i) && isDragged == false) { 		// && fruitDone[0] == false			forloob
				print ("bananaIsHit");
				fruits[i].transform.parent = cube.transform;

				if (i <= 1) {
					fruits[i].transform.localPosition = new Vector3(0.004f, -0.08f, 0.9f);
				} else {
					fruits[i].transform.localPosition = new Vector3(0.004f, -0.01f, 0.2f);
					fruits[i].transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
				}
				isDragged = true;
				//			fruitReady[0] = true;
				//			AppleHitSoundFX.Play (); 		
			}
			print ("Loop: "+i);
		}


//		if (col.CompareTag("Apple2") && isDragged == false && apple2Done == false) {
//			print ("apple2IsHit");
//		
//			apple2.transform.parent = cube.transform;
//			apple2.transform.localPosition = new Vector3(0.004f, -0.05f, 0.1f); //(0.004f, -0.05f, 0.25f)
//			apple2.transform.localScale = new Vector3 (2.2f, 2.2f, 2.2f);
//			isDragged = true;
//			apple2Ready = true;
//			AppleHitSoundFX.Play ();
//
//
//		}
//
//		if (col.CompareTag("Apple3") && isDragged == false && apple3Done == false) {
//			print ("apple3IsHit");
//
//			apple3.transform.parent = cube.transform;
//			apple3.transform.localPosition = new Vector3(0.004f, -0.05f, 0.1f);
//			apple3.transform.localScale = new Vector3 (2.2f, 2.2f, 2.2f);
//			isDragged = true;
//			apple3Ready = true;
//			AppleHitSoundFX.Play ();
//
//		}
//
		if (col.gameObject.name == ("StoneBowl")) {
			print ("basketIsHit");
			isDragged = false;
	
//			if (apple1Ready == true && apple1Done == false) {
//				apple1.transform.parent = ImageTarget2.transform;
//				apple1.transform.localPosition = new Vector3 (0.2f, 0.2f, 0.08f);
//				apple1.transform.localScale = new Vector3 (2.6f, 2.6f, 2.6f);
//				scoreCount++;
//				apple1Done = true;
//
////				getPoint = true;
//			}

//			if (apple2Ready == true && apple2Done == false) {
//				apple2.transform.parent = ImageTarget2.transform;
//				apple2.transform.localPosition = new Vector3(-0.16f , 0.21f, -0.1f);
//				apple2.transform.localScale = new Vector3 (2.6f, 2.6f, 2.6f);
//				scoreCount++;
//				apple2Done = true;
//			}
//
//			if (apple3Ready == true && apple3Done == false) {
//				apple3.transform.parent = ImageTarget2.transform;
//				apple3.transform.localPosition = new Vector3(0.21f , 0.2f, -0.19f); //0.12 , .. , 0,1
//				apple3.transform.localScale = new Vector3 (2.6f, 2.6f, 2.6f);
//				scoreCount++;
//				apple3Done = true;
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
