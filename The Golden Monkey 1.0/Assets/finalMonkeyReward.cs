using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalMonkeyReward : MonoBehaviour {

    public GameObject rewardObject;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(rewardObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
