using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour {

	public int scaleNum = 0;

	private int currentAns = 0;
	private int correctAns = 1;

	public bool leverPulled = false;
	public bool runOnce = false;

	public GameObject reward;
	public GameObject cameraObj;

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

		if (leverPulled == true && currentAns == correctAns && runOnce == false){
			print ("winner");
			StartCoroutine (RewardAnim());
			runOnce = true;
		}

		if (leverPulled == true && currentAns != correctAns){
			print ("loser");
		}
	}

	IEnumerator RewardAnim()
	{	yield return new WaitForSeconds(1);
		reward.SetActive(true);

		for (float i = 0.001f; i < 0.2f; i+=0.01f) {
			reward.transform.parent = cameraObj.transform;
			reward.transform.localPosition = new Vector3 (0, 0, 0.06f);		// (0, 0, 0.06f);
			reward.transform.localScale = new Vector3 (i,i,i);
			reward.transform.localRotation = Quaternion.Euler(-100, i, 8);
			yield return new WaitForSeconds(0.000000001f);
		}

		for (float i = 1.0f; i < 10000.0f; i+=1f) {
			reward.transform.localRotation = Quaternion.Euler(-100, i, 8);
			print ("Scale : "+i);
			yield return new WaitForSeconds(0.001f);
		}
	}
}
