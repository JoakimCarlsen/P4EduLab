using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winningScore : MonoBehaviour {

	public GameObject globalGame;
	public Text text;

	// Use this for initialization
	void Start () {
		globalGame = GameObject.Find("GlobalGameData");
		text.GetComponent<Text>().text = "Du svarede forkert " + globalGame.GetComponent<GlobalGameData>().wrongAnswer
			+ " gange.";
		GlobalGameData.GetComponent<GlobalGameData>().collectTreasure.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
