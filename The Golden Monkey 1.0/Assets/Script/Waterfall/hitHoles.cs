using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitHoles : MonoBehaviour {

	public GameObject[] holes;	
	public GameObject ball;
	public GameObject reward;
	public GameObject waterfall;

	public GameObject cameraObj;


	Vector3 startPos = new Vector3 (0, 0, 8);
	Vector3 endPos = new Vector3 (0, 0, 3);

	public bool turnOffWaterfall = false;
	public bool winning = false;
	public bool ballRolling = false;


	public Rigidbody rb;

    bool isReadyForSceneChange = false;
    public GameObject GlobalGameData;
    public GameObject signObject;

    // Use this for initialization
    void Start () {
        GlobalGameData = GameObject.Find("GlobalGameData");
        GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(false);
        cameraObj = GameObject.Find ("Camera");
	}
	
	// Update is called once per frame
	void Update () {


		if (winning == true) {
			float step = 1.0f * Time.deltaTime;
			transform.position = Vector3.Lerp(startPos, endPos, step);
		}
        if (isReadyForSceneChange == true && signObject.GetComponent<MeshRenderer>().enabled == false)
        {
            GlobalGameData.GetComponent<GlobalGameData>().ChangeScenes();
        }

    }

	void OnTriggerEnter(Collider col) {



		if (col.gameObject.name == ("Holes1")) { 		
			print("WRONG! hole1 hit");
			ball.transform.localPosition = new Vector3(0.3656f, 0.01f, -0.2354f);
			rb.isKinematic = true;
            GlobalGameData.GetComponent<GlobalGameData>().wrongAnswer += 1;
            GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(true);
        }

		if (col.gameObject.name == ("Holes2")) { 		
			print("CORRECT! hole2 hit");
			winning = true;
			waterfall.SetActive (false);
			StartCoroutine (RewardAnim());

			ball.transform.localPosition = new Vector3(0.3681f, 0.01f, 0.2262f);
//			endPos = transform.position;
//			reward.transform.localPosition = Vector3.Lerp (startPos, endPos, Time.deltaTime);
			// reward.transform.localPosition = new Vector3(0, 0, 2);
			// reward.transform.localRotation = new Vector3(0, 0, 0);
			// reward.transform.localPosition = new Vector3(0.5f, 0.5f, 0.5f);

			rb.isKinematic = true;

            GlobalGameData.GetComponent<GlobalGameData>().currentPiecesOfTreasure += 1;
            isReadyForSceneChange = true;
        }

		if (col.gameObject.name == ("Holes3")) { 		
			print("WRONG! hole3 hit");
			ball.transform.localPosition = new Vector3(-0.3582f, 0.01f, 0.2209f);
			rb.isKinematic = true;
            GlobalGameData.GetComponent<GlobalGameData>().wrongAnswer += 1;
            GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(true);

        }

		if (col.gameObject.name == ("Holes4")) { 		
			print("WRONG! hole4 hit");
			ball.transform.localPosition = new Vector3(-0.3439f, 0.01f, -0.2349f);
			rb.isKinematic = true;
            GlobalGameData.GetComponent<GlobalGameData>().wrongAnswer += 1;
            GlobalGameData.GetComponent<GlobalGameData>().restartButton.SetActive(true);

        }
	}

	IEnumerator RewardAnim()
	{	yield return new WaitForSeconds(1);
		reward.SetActive (true);

		for (float i = 0.0007f; i < 0.009f; i+=0.0001f) {
			reward.transform.parent = cameraObj.transform;
			reward.transform.localPosition = new Vector3 (0, 0, 0.06f);		// (0, 0, 0.06f);
			reward.transform.localScale = new Vector3 (i,i,i);
			reward.transform.localRotation = Quaternion.Euler(0, i, 8);
			yield return new WaitForSeconds(0.0000000000000000000001f);
		}

		for (float i = 1.0f; i < 10000.0f; i+=1.0f) {
			reward.transform.localRotation = Quaternion.Euler(0, i, 8);
			yield return new WaitForSeconds(0.001f);
		}
	}
}
