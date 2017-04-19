using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStateMachine : MonoBehaviour {

    public GameObject Player;
    public GameObject[] positionObjects;
    public bool[] finishQuest ;

    public enum WorldStates{
        Start,
        Position1,
        Position2,
        Position3,
        Position4,
        Position5,
        Finish
    }

    public WorldStates currentState = WorldStates.Start;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        DontDestroyOnLoad(this.gameObject);
        
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case WorldStates.Start:
                Player.transform.position = positionObjects[0].transform.position;
                break;
            case WorldStates.Position1:
                Player.transform.position = positionObjects[1].transform.position;
               
                break;
            case WorldStates.Position2:
                Player.transform.position = positionObjects[2].transform.position;
                break;
            case WorldStates.Position3:
                Player.transform.position = positionObjects[3].transform.position;
                break;
            case WorldStates.Position4:
                Player.transform.position = positionObjects[4].transform.position;
                break;
            case WorldStates.Position5:
                Player.transform.position = positionObjects[5].transform.position;
                break;
            case WorldStates.Finish:
                break;
        }
            
	}
}
