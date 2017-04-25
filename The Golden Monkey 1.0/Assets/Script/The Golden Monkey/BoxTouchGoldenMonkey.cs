using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouchGoldenMonkey : MonoBehaviour
{

	public GameObject[] rock;
	public GameObject kamera;
	public GameObject imageTarget;
	public GameObject scaleBehaviour;

	private int temp;
	private int numRock = 0;

	// Use this for initialization
	void Start ()
	{
		kamera = GameObject.Find ("Camera");

		imageTarget = GameObject.Find ("ScaleMonkey");
	}

	// Update is called once per frame
	void Update ()
	{

	}

	//  Method for collision
	void OnTriggerEnter (Collider col)
	{
		//if the name of the collided gameobject is Rock1 the following happens

		if (col.gameObject.name == "Rock" + numRock) {
			rock [numRock].transform.parent = kamera.transform;
			rock [numRock].transform.localPosition = new Vector3 (0.1f, 0f, 2f);
			rock [numRock].transform.localRotation = Quaternion.Euler (0, 0, 0);
			rock [numRock].transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			rock [numRock].GetComponent<BoxCollider> ().isTrigger = false;
		
		}
		if (col.gameObject.name == "Scale") {
			temp = scaleBehaviour.GetComponent<ScaleBehaviour> ().scaleNum;
			scaleBehaviour.GetComponent<ScaleBehaviour> ().scaleNum = temp + 1;
			rock [numRock].transform.parent = imageTarget.transform;
			rock [numRock].transform.localPosition = new Vector3 (0, 0.3f, 0);
			rock [numRock].transform.localRotation = Quaternion.Euler (0, 0, 0);
			numRock++;
		}

		if (col.gameObject.name == "Lever") {
			scaleBehaviour.GetComponent<ScaleBehaviour>().leverPulled = true;
		}
	}

}