using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MenuScript : MonoBehaviour {

    public Button startButton;
    public GameObject globalGameData;

	// Use this for initialization
	void Start () {
        globalGameData = GameObject.Find("GlobalDataObject");

        startButton.onClick.AddListener(globalGameData.GetComponent<GlobalGameData>().ChangeScenes);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
