using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardReset : MonoBehaviour {

	public GameObject obj;
	public GameObject objGlobal;

	// Use this for initialization
	void Start () {
		objGlobal = GameObject.Find("GlobalGameData");
	}
	
	// Update is called once per frame
	void Update () {
		if(obj.GetComponent<MeshCollider>().enabled == true){
			objGlobal.GetComponent<GlobalGameData>().ChangeScenes();
			print ("Fuck you, bitch");
		}
	}
}
