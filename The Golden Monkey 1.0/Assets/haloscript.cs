using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haloscript : MonoBehaviour {
    
    public GameObject activateLava;
    public GameObject lavaLight;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (activateLava.GetComponent<Renderer>().enabled == true)
        {
            lavaLight.SetActive(true);
        }
        else if (activateLava.GetComponent<Renderer>().enabled == false)
        {
            lavaLight.SetActive(false);
        }

    }
}
