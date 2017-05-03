using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouchGoldenMonkey : MonoBehaviour
{
	AudioSource audioFeedback;

	public GameObject[] rock;
	public GameObject kamera;
	public GameObject imageTarget;
	public GameObject scaleBehaviour;
	public GameObject lever;

	public int temp;
	private int temp2;
	private int switchNum = 0;

	private bool holdingRock = false;

	// Use this for initialization
	void Start ()
	{
		kamera = GameObject.Find ("Camera");

		imageTarget = GameObject.Find ("ScaleMonkey");

		audioFeedback = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update ()
	{

	}

	//  Method for collision
	void OnTriggerEnter (Collider col)
	{
		//if the name of the collided gameobject is Rock1 the following happens
		for (int numRock = 0; numRock <= 7; numRock++) {
			if (col.gameObject.name == "Rock" + numRock && holdingRock == false) {

				audioFeedback.Play(); 		

				temp2 = numRock;
				holdingRock = true;
				rock [numRock].transform.parent = kamera.transform;
				rock [numRock].transform.localPosition = new Vector3 (0, -0.15f, 0.8f);
				rock [numRock].transform.localRotation = Quaternion.Euler (0, 0, 0);
				rock [numRock].transform.localScale = new Vector3 (10, 10, 10);
				rock [numRock].GetComponent<MeshCollider> ().isTrigger = false;
				switchNum++;
			}
		}

		if (col.gameObject.name == "BowlBox" && holdingRock == true) {

			audioFeedback.Play(); 		

			temp = scaleBehaviour.GetComponent<ScaleBehaviour> ().scaleNum;
			scaleBehaviour.GetComponent<ScaleBehaviour> ().scaleNum = temp + 1;
			holdingRock = false;
			switch (switchNum) {
			case 1:
				rock [temp2].transform.parent = imageTarget.transform;
				rock [temp2].transform.localPosition = new Vector3 (-0.05f, 0.24f, 0.084f);
				rock [temp2].transform.localRotation = Quaternion.Euler (0, 0, 0);
				rock [temp2].transform.localScale = new Vector3 (4, 4, 4);
				break;

			case 2:
				rock [temp2].transform.parent = imageTarget.transform;
				rock [temp2].transform.localPosition = new Vector3 (0.042f, 0.2283f, 0.084f);
				rock [temp2].transform.localRotation = Quaternion.Euler (0, 0, 90);
				rock [temp2].transform.localScale = new Vector3 (4, 4, 4);
				break;

			case 3:
				rock [temp2].transform.parent = imageTarget.transform;
				rock [temp2].transform.localPosition = new Vector3 (-0.008f, 0.289f, 0.084f);
				rock [temp2].transform.localRotation = Quaternion.Euler (170, 0, 0);
				rock [temp2].transform.localScale = new Vector3 (4,4,4);
				break;

			default:
				rock [temp2].transform.parent = imageTarget.transform;
				rock [temp2].transform.localPosition = new Vector3 (-0.0099f, 0.2444f, 0.1276f);
				rock [temp2].transform.localRotation = Quaternion.Euler (0, 90, 8);
				rock [temp2].transform.localScale = new Vector3 (4,4,4);
				break;
			}
		}

		if (col.gameObject.name == "Lever") {

			audioFeedback.Play(); 		

			scaleBehaviour.GetComponent<ScaleBehaviour> ().leverPulled = true;
			lever.transform.localRotation = Quaternion.Euler(0,180,0);
		}
	}

}