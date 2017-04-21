using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouchGoldenMonkey : MonoBehaviour
{

	public GameObject rock;

	public GameObject kamera;

	public GameObject imageTarget;

	// Use this for initialization
	void Start ()
	{
		kamera = GameObject.Find ("Camera");

		imageTarget = GameObject.Find ("ImageTarget");
	}

	// Update is called once per frame
	void Update ()
	{

	}

	//  Method for collision
	void OnTriggerEnter (Collider col)
	{
		//if the name of the collided gameobject is Rock1 the following happens
		if (col.gameObject.name == "Rock1") {
			rock.transform.parent = kamera.transform;
			rock.transform.localPosition = new Vector3 (0.1f, 0f, 0f);
			rock.transform.localRotation = Quaternion.Euler (0,0,0);
			rock.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
			rock.GetComponent<BoxCollider>().isTrigger = false;
		}

		if (col.gameObject.name == "Scale") {
			print ("faefaorij");
			rock.transform.parent = imageTarget.transform;
			rock.transform.localPosition = new Vector3(0,0,0);
			rock.transform.localRotation = Quaternion.Euler (0,0,0);
		}
	}

}