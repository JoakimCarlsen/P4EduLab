using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTigerTrigger : MonoBehaviour {

    public bool keyAttached = false;
    public GameObject keyObject;
    public GameObject keyHandle;
    public GameObject reward;
    public GameObject locker;
    public GameObject cage;
	public GameObject cameraObj;

	public bool runOnce = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            keyObject = other.gameObject; 
            print("Pick up key");
            keyAttached = true;
            keyObject.GetComponent<BoxCollider>().enabled = false; 
            keyObject.transform.parent = keyHandle.transform;
            keyObject.transform.position = keyHandle.transform.position;
            keyObject.transform.localEulerAngles = new Vector3(0,75,0);
            keyObject.transform.localScale = new Vector3(10f, 10f, 10f);
            
        }

        if (keyAttached == true)
        {
            if (keyObject.GetComponent<Key>().rightKey == false && other.gameObject.tag == "Lock")
            {
                print("Wrong Lock");
               
                Destroy(keyObject);

            }
			else if (keyObject.GetComponent<Key>().rightKey == true && other.gameObject.tag == "Lock" && runOnce == false)
            {
                print("The Right Key");
				StartCoroutine (RewardAnim());
				runOnce = true;
                Destroy(keyObject);
                Destroy(locker);
                Destroy(cage);
            }
        }
        
    }

	IEnumerator RewardAnim()
	{	yield return new WaitForSeconds(1);
		reward.SetActive(true);

		for (float i = 0.001f; i < 0.4f; i+=0.01f) {
			reward.transform.parent = cameraObj.transform;
			reward.transform.localPosition = new Vector3 (0, 0, 0.06f);		// (0, 0, 0.06f);
			reward.transform.localScale = new Vector3 (i,i,i);
			reward.transform.localRotation = Quaternion.Euler(-100, i, 8);
			yield return new WaitForSeconds(0.000000001f);
		}

		for (float i = 1.0f; i < 10000.0f; i+=1f) {
			reward.transform.localRotation = Quaternion.Euler(-100, i, 8);
			print ("Scale : "+i);
			yield return new WaitForSeconds(0.001f);
		}
	}
}
