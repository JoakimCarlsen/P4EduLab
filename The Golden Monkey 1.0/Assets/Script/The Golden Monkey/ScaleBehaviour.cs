using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour {

	public int scaleNum = 0;

	private int currentAns = 0;
	private int correctAns = 3;

	bool leverPulled = false;


	public GameObject arrow;

	// Use this for initialization
	void Start () {
		arrow = GameObject.Find("ScaleArrow");
	}
	
	// Update is called once per frame
	void Update () {
		if (scaleNum == 0) {
			arrow.transform.localPosition = new Vector3 (0,0,-1.5f);
			currentAns = 0;
		} else if (scaleNum == 1) {
			arrow.transform.localPosition = new Vector3(0,0.6f,-1);
			currentAns = 1;
		} else if (scaleNum == 2) {
			arrow.transform.localPosition = new Vector3 (0,1.2f,0);
			currentAns = 2;
		} else if (scaleNum == 3) {
			arrow.transform.localPosition = new Vector3 (0,0.6f,1f);
			currentAns = 3;
		} else if (scaleNum == 4) {
			arrow.transform.localPosition = new Vector3 (0,0,1.5f);
			currentAns = 4;
		}

		if (leverPulled == true && currentAns == correctAns){
			print ("winner");
		}

		if (leverPulled == true && currentAns != correctAns){
			print ("loser");
		}
	}
}
