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
            else if (keyObject.GetComponent<Key>().rightKey == true && other.gameObject.tag == "Lock")
            {
                print("The Right Key");
                reward.SetActive(true);
                Destroy(keyObject);
                Destroy(locker);
                Destroy(cage);
            }
        }
        
        

        
    }
}
