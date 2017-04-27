using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterfallAnimation : MonoBehaviour {

	public GameObject [] waterfallAnim;
	public bool Shift = false;
	public int ResetInt;


	// Use this for initialization
	void Start () {
		StartCoroutine (WaterfallAnimationDelay ());
	}

	// Update is called once per frame
	void Update () {
		

	}



	IEnumerator WaterfallAnimationDelay()
	{
		
		for (ResetInt = 0; ResetInt < waterfallAnim.Length; ResetInt++) {
			
			waterfallAnim [ResetInt].SetActive (true);

			if (ResetInt == 0) {
				yield return new WaitForSeconds(0.12f);
				waterfallAnim [ResetInt].SetActive (false);
			
			}


			else {
				waterfallAnim [ResetInt - 1].SetActive (false);
			}
			yield return new WaitForSeconds(0.12f);



			if (ResetInt == 7) {
				ResetInt = 0;
				waterfallAnim [7].SetActive (false);
			} 
		} 
	}
}
