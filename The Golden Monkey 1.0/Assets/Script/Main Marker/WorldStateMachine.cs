using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStateMachine : MonoBehaviour {

    public GameObject Player;
    public GameObject[] positionObjects;
    public bool[] finishQuest ;

    public enum WorldStates{
        Waterfall,
        Totem,
        TigerCage,
        DistractMonkey,
        Tempel
    }

    public WorldStates currentState;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        DontDestroyOnLoad(this.gameObject);
        
        
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case WorldStates.Waterfall:
                Player.transform.position = positionObjects[0].transform.position;
                break;
            case WorldStates.Totem:
                Player.transform.position = positionObjects[1].transform.position;
               
                break;
            case WorldStates.TigerCage:
                Player.transform.position = positionObjects[2].transform.position;
                break;
            case WorldStates.DistractMonkey:
                Player.transform.position = positionObjects[3].transform.position;
                break;
            case WorldStates.Tempel:
                Player.transform.position = positionObjects[4].transform.position;
                break;
        }
            
	}
}
