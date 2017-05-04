using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsHit : MonoBehaviour {

	AudioSource audioFeedback;

	public GameObject[] fruits;								// apples, pears and bananas

	public GameObject cube;
	public GameObject stoneBowl;
	public GameObject ImageTarget2;

	public GameObject reward;
	public GameObject cameraObj;

	//	AudioSource AppleHitSoundFX;
	int rememberFruit = -1;										// creates integer used as a temporary varible to remember which fruit was taken

	int[] rememberFruitsArray;				// NEED FIX			// remember fruits to get the correct fruits attatched to camera so the bowl with fruit can be moved

//	-------------------------------- Winning State
	int appleScore = 2;										// integers give each fruit a value that will be used in the winning state. The numbers are chosen specifically 
	int bananaScore = 1;									// to make sure that there are only certain possibilities to answer correct.
	int pearScore = 5;
	int scoreCount;

	bool isDragged = false;									// boolean to make sure that only one apple at a time can be moved
	public bool [] fruitDone;                               // boolean array to know when the fruit is in the bowl


    public GameObject GlobalGameData;
    public GameObject signObject;






    // Use this for initialization
    void Start () {
        GlobalGameData = GameObject.Find("GlobalGameData");
        GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(false);
      //  GlobalGameData.GetComponent<GlobalGameData>().collectTreasure.SetActive(false);
        GlobalGameData.GetComponent<GlobalGameData>().progressText.GetComponent<Text>().enabled = true;
        for (int i = 0; i < fruitDone.Length; i++) {				// assign booleans in array with a true value

			fruitDone [i] = false;
		}

		audioFeedback = GetComponent<AudioSource> ();

		cube = GameObject.Find ("Camera");

		stoneBowl = GameObject.Find ("StoneBowl");

		ImageTarget2 = GameObject.Find ("ImageTarget2");

        //		AppleHitSoundFX = GetComponent<AudioSource> ();
        GlobalGameData.GetComponent<GlobalGameData>().ActivateMonkey();

    }



	// Update is called once per frame
	void Update () {



        //	----------------------------------Winning State
        if (scoreCount == 3) {
			print("possibility 1 answered");
            GlobalGameData.GetComponent<GlobalGameData>().wrongAnswer += 1;
            GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(true);
            scoreCount = 0;
		}
		if (scoreCount == 4) {
			print("possibility 2 answered");
            GlobalGameData.GetComponent<GlobalGameData>().wrongAnswer += 1;
            GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(true);
            scoreCount = 0;
		}

		if (scoreCount == 6) {
			print("possibility 3 answered");
            GlobalGameData.GetComponent<GlobalGameData>().wrongAnswer += 1;
            GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(true);
            scoreCount = 0;

		}

		if (scoreCount == 7) {
			print("possibility 4 answered");
			scoreCount = 0;
			StartCoroutine (RewardAnim());
          //  GlobalGameData.GetComponent<GlobalGameData>().collectTreasure.SetActive(true);
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

				audioFeedback.Play(); 		
			}


			if (col.gameObject.name == ("StoneBowl") && fruitDone[rememberFruit] == false) {
				print ("basketIsHit");
				isDragged = false;
				fruits[rememberFruit].transform.parent = ImageTarget2.transform;
				fruitDone [rememberFruit] = true;

				audioFeedback.Play(); 		

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

	IEnumerator RewardAnim()
	{	yield return new WaitForSeconds(1);
		reward.SetActive (true);

		for (float i = 0.1f; i < 0.5f; i+=0.01f) {
			reward.transform.parent = cameraObj.transform;
			reward.transform.localPosition = new Vector3 (0, 0, 0.06f);		// (0, 0, 0.06f);
			reward.transform.localScale = new Vector3 (i,i,i);
			reward.transform.localRotation = Quaternion.Euler(-68, i, 8);
			yield return new WaitForSeconds(0.001f);
			print ("Scale: " +i);
		}

		for (float i = 1.0f; i < 10000.0f; i+=0.9f) {
			reward.transform.localRotation = Quaternion.Euler(-68, i, 8);
			yield return new WaitForSeconds(0.001f);
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
