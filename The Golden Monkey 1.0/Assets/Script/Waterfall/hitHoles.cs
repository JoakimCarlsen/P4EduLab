using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitHoles : MonoBehaviour {

	public GameObject[] holes;	
	public GameObject ball;
	public GameObject reward;
	public GameObject waterfall;

	public bool turnOffWaterfall = false;
	public bool ballRolling = false;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
//		rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (ballRolling == false) {
//			rb.velocity = Vector3.zero;
//			rb.angularVelocity = Vector3.zero;
		}
	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.name == ("Holes1")) { 		
			print("WRONG! hole1 hit");
			ball.transform.localPosition = new Vector3(0.3656f, 0.01f, -0.2354f);
			rb.isKinematic = true;
			}

		if (col.gameObject.name == ("Holes2")) { 		
			print("CORRECT! hole2 hit");
//			turnOffWaterfall = true;
			waterfall.SetActive (false);
			reward.SetActive (true);

			ball.transform.localPosition = new Vector3(0.3681f, 0.01f, 0.2262f);
			rb.isKinematic = true;
			}

		if (col.gameObject.name == ("Holes3")) { 		
			print("WRONG! hole3 hit");
			ball.transform.localPosition = new Vector3(-0.3582f, 0.01f, 0.2209f);
			rb.isKinematic = true;

			}

		if (col.gameObject.name == ("Holes4")) { 		
			print("WRONG! hole4 hit");
			ball.transform.localPosition = new Vector3(-0.3439f, 0.01f, -0.2349f);
			rb.isKinematic = true;

			}

//		if (col.gameObject.name == ("Cube")) {
//			print ("cube is hit");
//			ballRolling = true;
//			rb.isKinematic = true;
//			} 
//
//		if (col.gameObject.name != ("Cube")) {
//			ballRolling = false;
//
//			}
	}
}
