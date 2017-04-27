using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketSound : MonoBehaviour {

	AudioSource BasketHitSoundFX;

	// Use this for initialization
	void Start () {
		BasketHitSoundFX = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {

		if (col.CompareTag ("Apple1")) {
			print ("BasketIsHit");
			BasketHitSoundFX.Play (); 		
		}

		if (col.CompareTag ("Apple2")) {
			print ("BasketIsHit");
			BasketHitSoundFX.Play (); 		
		}

		if (col.CompareTag ("Apple3")) {
			print ("BasketIsHit");
			BasketHitSoundFX.Play (); 		
		}
	}
}
