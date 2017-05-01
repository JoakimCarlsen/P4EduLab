using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingSkybox : MonoBehaviour {
    public Material skybox;
    float adjustment = 0.5f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * adjustment);

    }
}
