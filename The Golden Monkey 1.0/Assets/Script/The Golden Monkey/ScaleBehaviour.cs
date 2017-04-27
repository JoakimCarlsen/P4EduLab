using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour {

	public int scaleNum = 0;

	private int currentAns = 0;
	private int correctAns = 1;

	public bool leverPulled = false;

	public GameObject reward;

	private GameObject arrow;

	// Use this for initialization
	void Start () {
		arrow = GameObject.Find("ScaleArrow");
	}
	
	// Update is called once per frame
	void Update () {
		// THIS NEEDS TO BE (S)LERPED IN THE FUTURE
		if (scaleNum == 0) {
			arrow.transform.localEulerAngles = new Vector3 (0,90,90);
			currentAns = 0;
		} else if (scaleNum == 1) {
			arrow.transform.localEulerAngles = new Vector3(0,135,90);
			currentAns = 1;
		} else if (scaleNum == 2) {
			arrow.transform.localEulerAngles = new Vector3 (0,180,90);
			currentAns = 2;
		} else if (scaleNum == 3) {
			arrow.transform.localEulerAngles = new Vector3 (0,225,90);
			currentAns = 3;
		} else if (scaleNum == 4) {
			arrow.transform.localEulerAngles = new Vector3 (0,270,90);
			currentAns = 4;
		}

		if (leverPulled == true && currentAns == correctAns){
			print ("winner");
			reward.SetActive(true);
		}

		if (leverPulled == true && currentAns != correctAns){
			print ("loser");
		}
	}
}
