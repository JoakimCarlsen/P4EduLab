using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalGameData : MonoBehaviour
{

    public Dropdown pickStarterScene;
    public Button startButton;
    public GameObject globalDataObject;
    public int startValue;
    public int currentPiecesOfTreasure = 0;
    public int maxPiecesOfTreasure = 5;


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(globalDataObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PickStartScene()
    {
        if (pickStarterScene.GetComponent<Dropdown>().value == 0)
        {
            startValue = 1;   
            SceneManager.LoadScene(1);
        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 1)
        {
            startValue = 2;
            SceneManager.LoadScene(2);
        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 2)
        {
            startValue = 3;
            SceneManager.LoadScene(3);

        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 3)
        {
            startValue = 4;
            SceneManager.LoadScene(4);
        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 4)
        {
            startValue = 5;
            SceneManager.LoadScene(5);
        }
    }

    public void ChangeScenes()
    {
        switch (startValue)
        {
            case 1:
                switch (currentPiecesOfTreasure)
                {
                   
                    case 1:
                        SceneManager.LoadScene(2);
                        break;
                    case 2:
                        SceneManager.LoadScene(3);
                        break;
                    case 3:
                        SceneManager.LoadScene(4);
                        break;
                    case 4:
                        SceneManager.LoadScene(5);
                        break;
                }
                break;
            case 2:
                switch (currentPiecesOfTreasure)
                {
                    case 1:
                        SceneManager.LoadScene(3);
                        break;
                    case 2:
                        SceneManager.LoadScene(4);
                        break;
                    case 3:
                        SceneManager.LoadScene(5);
                        break;
                    case 4:
                        SceneManager.LoadScene(1);
                        break;
                }

                break;
            case 3:
                switch (currentPiecesOfTreasure)
                {
                    case 1:
                        SceneManager.LoadScene(4);
                        break;
                    case 2:
                        SceneManager.LoadScene(5);
                        break;
                    case 3:
                        SceneManager.LoadScene(1);
                        break;
                    case 4:
                        SceneManager.LoadScene(2);
                        break;
                }
                break;
            case 4:
                switch (currentPiecesOfTreasure)
                {
                    case 1:
                        SceneManager.LoadScene(5);
                        break;
                    case 2:
                        SceneManager.LoadScene(1);
                        break;
                    case 3:
                        SceneManager.LoadScene(2);
                        break;
                    case 4:
                        SceneManager.LoadScene(3);
                        break;
                }
                break;
            case 5:
                switch (currentPiecesOfTreasure)
                {
                    case 1:
                        SceneManager.LoadScene(1);
                        break;
                    case 2:
                        SceneManager.LoadScene(2);
                        break;
                    case 3:
                        SceneManager.LoadScene(3);
                        break;
                    case 4:
                        SceneManager.LoadScene(4);
                        break;
                }
                break;
        }

    }
}
