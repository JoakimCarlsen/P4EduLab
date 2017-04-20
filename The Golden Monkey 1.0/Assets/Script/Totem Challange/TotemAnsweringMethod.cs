using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TotemAnsweringMethod : MonoBehaviour {

	public bool sign1 = false;
	public bool sign2 = false;
	public bool sign3 = false;
	public bool sign4 = false;

	public string guess;
	public string answer = "4321";

	public List<int> signOrder = new List<int>();


	public GameObject[] buttons;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (sign1 == true)
		{
			signOrder.Add (1);
			sign1 =false;
			// Remove onTrigger for GameObject here so it cannot be pressed again
		}

		if (sign2 == true)
		{
			signOrder.Add (2);
			sign2 =false;
			// Remove onTrigger for GameObject here so it cannot be pressed again
		}

		if (sign3 == true)
		{
			signOrder.Add (3);
			sign3 =false;
			// Remove onTrigger for GameObject here so it cannot be pressed again
		}

		if (sign4 == true)
		{
			signOrder.Add (4);
			sign4 =false;
			// Remove onTrigger for GameObject here so it cannot be pressed again
		}

		if (signOrder.Count == 4){
			guess = signOrder[0].ToString()+signOrder[1].ToString()+signOrder[2].ToString()+signOrder[3].ToString();

			if (guess == answer)
			{
				print ("HEEU ERGETJHIAER");
			} else if (guess != answer){
				print ("WRONG MOFO");
			}
		}
			

	}
}
