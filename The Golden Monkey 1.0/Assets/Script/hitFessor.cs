using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitFessor : MonoBehaviour {
    public GameObject GlobalGameData;
    public int pieceOfMonkeyStatue;
    public int plusOne;
    public bool fessorHit = false;

    // Use this for initialization
    void Start () {
        GlobalGameData = GameObject.Find("GlobalGameData");
        fessorHit = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && fessorHit == false)
        {
          
            GlobalGameData.GetComponent<GlobalGameData>().activatedMonkey[pieceOfMonkeyStatue] = true;
            GlobalGameData.GetComponent<GlobalGameData>().currentPiecesOfTreasure += plusOne;
            print("should have added 1 to current pieces");
            fessorHit = true;
            GlobalGameData.GetComponent<GlobalGameData>().ChangeScenes();
            

        }
    }
}
