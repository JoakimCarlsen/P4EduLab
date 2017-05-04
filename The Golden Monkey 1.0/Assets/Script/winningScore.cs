using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winningScore : MonoBehaviour {

	public GameObject globalGame;
	public Text errorText;
    public Text timeScorer;

	// Use this for initialization
	void Start () {
		globalGame = GameObject.Find("GlobalGameData");
		errorText.GetComponent<Text>().text = "Du svarede forkert " + globalGame.GetComponent<GlobalGameData>().wrongAnswer
			+ " gange.";
        errorText.GetComponent<Text>().text = "Du tid var " + globalGame.GetComponent<GlobalGameData>().amountOfTimePlayed;
     //   globalGame.GetComponent<GlobalGameData>().collectTreasure.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
