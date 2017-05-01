using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TotemAnsweringMethod : MonoBehaviour {

	public bool sign1 = false;
	public bool sign2 = false;
	public bool sign3 = false;
	public bool sign4 = false;
	public bool runOnce = false;

	public string guess;

	// Correct order of the correct answer
	public string answer = "4312";

	// A list of ints for the sign order
	public List<int> signOrder = new List<int>();

	public GameObject reward;

	public GameObject cameraObj;

	// Array of the four buttons
	public GameObject[] buttons;

	public GameObject[] models;

    bool isReadyForSceneChange = false;
    public GameObject GlobalGameData;
    public GameObject signObject;


    // Use this for initialization
    void Start () {
        GlobalGameData = GameObject.Find("GlobalGameData");
    }
	
	// Update is called once per frame
	void Update () {
        if (isReadyForSceneChange == true && signObject.GetComponent<MeshRenderer>().enabled == false)
        {
            GlobalGameData.GetComponent<GlobalGameData>().ChangeScenes();
        }
        if (sign1 == true)
		{
			// Adds a 1 to the signOrder list
			signOrder.Add (1);
			// The bool to activate this function is turned false, so it only adds one number
			sign1 = false;
			// The trigger for the gameObject is turned false, so it cannot be pressed more than once
			buttons[0].GetComponent<BoxCollider>().isTrigger= false;
			models[0].SetActive(false);
			models[4].SetActive(true);

		}

		if (sign2 == true)
		{
			signOrder.Add (2);
			sign2 = false;
			buttons[1].GetComponent<BoxCollider>().isTrigger= false;
			models[1].SetActive(false);
			models[5].SetActive(true);

		}

		if (sign3 == true)
		{
			signOrder.Add (3);
			sign3 = false;
			buttons[2].GetComponent<BoxCollider>().isTrigger= false;
			models[2].SetActive(false);
			models[6].SetActive(true);

		}

		if (sign4 == true)
		{
			signOrder.Add (4);
			sign4 = false;
			buttons[3].GetComponent<BoxCollider>().isTrigger= false;
			models[3].SetActive(false);
			models[7].SetActive(true);
		}

		// When the length of the signOrder list is 4 the following happens
		if (signOrder.Count == 4){
			// The list of the 4 numbers are turned into a string and saved in the guess variable
			guess = signOrder[0].ToString()+signOrder[1].ToString()+signOrder[2].ToString()+signOrder[3].ToString();

			// The guess and the answer variables are compared. If they are the same you win, if not you lose
			if (guess == answer && runOnce == false)
			{
				StartCoroutine (RewardAnim());
				runOnce = true;
				print ("Correct");
                GlobalGameData.GetComponent<GlobalGameData>().currentPiecesOfTreasure += 1;
                isReadyForSceneChange = true;
            } else if (guess != answer){
				print ("Wrong");
			}
		}
			

	}

	IEnumerator RewardAnim()
	{	yield return new WaitForSeconds(1);
		reward.SetActive(true);

		for (float i = 0.001f; i < 0.4f; i+=0.01f) {
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
