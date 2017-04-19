using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TotemAnsweringMethod : MonoBehaviour {

	public bool sign1 = false;
	public bool sign2 = false;
	public bool sign3 = false;
	public bool sign4 = false;

	public string guess;

	// Correct order of the correct answer
	public string answer = "4321";

	// A list of ints for the sign order
	public List<int> signOrder = new List<int>();

	// Array of the four buttons
	public GameObject[] buttons;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (sign1 == true)
		{
			// Adds a 1 to the signOrder list
			signOrder.Add (1);
			// The bool to activate this function is turned false, so it only adds one number
			sign1 =false;
			// The trigger for the gameObject is turned false, so it cannot be pressed more than once
			buttons[0].GetComponent<BoxCollider>().isTrigger= false;
		}

		if (sign2 == true)
		{
			signOrder.Add (2);
			sign2 =false;
			buttons[1].GetComponent<BoxCollider>().isTrigger= false;
		}

		if (sign3 == true)
		{
			signOrder.Add (3);
			sign3 =false;
			buttons[2].GetComponent<BoxCollider>().isTrigger= false;
		}

		if (sign4 == true)
		{
			signOrder.Add (4);
			sign4 =false;
			buttons[3].GetComponent<BoxCollider>().isTrigger= false;
		}

		// When the length of the signOrder list is 4 the following happens
		if (signOrder.Count == 4){
			// The list of the 4 numbers are turned into a string and saved in the guess variable
			guess = signOrder[0].ToString()+signOrder[1].ToString()+signOrder[2].ToString()+signOrder[3].ToString();

			// The guess and the answer variables are compared. If they are the same you win, if not you lose
			if (guess == answer)
			{
				print ("Correct");
			} else if (guess != answer){
				print ("Wrong");
			}
		}
			

	}
}
