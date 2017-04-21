using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTigerTrigger : MonoBehaviour {

    public bool keyAttached = false;
    public GameObject keyObject;
    public GameObject keyHandle;
    public GameObject reward;
    public GameObject locks; 

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
            keyObject.GetComponent<BoxCollider>().size = new Vector3(0, 0, 0); 
            keyObject.transform.parent = keyHandle.transform;
            keyObject.transform.position = keyHandle.transform.position;
            keyObject.transform.rotation = new Quaternion(0, 0, 0, 0);
            keyObject.transform.localScale = new Vector3(50f, 50f, 7f);
        }

        if (keyAttached == true)
        {
            if (keyObject.GetComponent<Key>().rightKey == false)
            {
                print("Wrong Lock");
               
                Destroy(keyObject);

            }
            else if (keyObject.GetComponent<Key>().rightKey == true)
            {
                print("The Right Key");
                reward.SetActive(true);
                Destroy(keyObject);
            }
        }
        
        

        
    }
}
