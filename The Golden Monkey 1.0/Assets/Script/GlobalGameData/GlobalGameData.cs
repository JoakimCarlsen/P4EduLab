using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalGameData : MonoBehaviour
{

    public Dropdown pickStarterScene;
    public Button startButton;
    public Text progressText;
    public GameObject collectTreasure;
    public GameObject globalDataObject;
    public GameObject finalReward; 
    public GameObject restartButton = null;

    public int startValue;
    public int currentPiecesOfTreasure = 0;
    public int maxPiecesOfTreasure = 5;
    public int wrongAnswer = 0; 

	private bool loadOnce = false;


    // Use this for initialization
    void Start()
    {
        
        finalReward.SetActive(false);
        restartButton = GameObject.Find("Restart");
        collectTreasure = GameObject.Find("Collect");
        restartButton.GetComponent<Button>().onClick.AddListener(ChangeScenes);
		collectTreasure.GetComponent<Button>().onClick.AddListener(AddOneToCurrentPiece);
        collectTreasure.GetComponent<Button>().onClick.AddListener(ChangeScenes);
		restartButton.SetActive(false);
        collectTreasure.SetActive(false);
        DontDestroyOnLoad(globalDataObject);
    }

    // Update is called once per frame
    void Update()
    {
        WinningState();
        progressText.GetComponent<Text>().text = currentPiecesOfTreasure.ToString() + "/" + maxPiecesOfTreasure.ToString();
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
            SceneManager.LoadScene(1);
        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 2)
        {
            startValue = 3;
            SceneManager.LoadScene(1);

        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 3)
        {
            startValue = 4;
            SceneManager.LoadScene(1);
        }
        else if (pickStarterScene.GetComponent<Dropdown>().value == 4)
        {
            startValue = 5;
            SceneManager.LoadScene(1);
        }
    }

    public void ChangeScenes()
    {
        switch (startValue)
        {
            case 1:
                switch (currentPiecesOfTreasure)
                {
                    case 0:
                        SceneManager.LoadScene(2);
                        break;
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
                        SceneManager.LoadScene(6);
                        break;
                }
                break;
            case 2:
                switch (currentPiecesOfTreasure)
                {
                    case 0:
                        SceneManager.LoadScene(3);
                        break;
                    case 1:
                        SceneManager.LoadScene(4);
                        break;
                    case 2:
                        SceneManager.LoadScene(5);
                        break;
                    case 3:
                        SceneManager.LoadScene(6);
                        break;
                    case 4:
                        SceneManager.LoadScene(2);
                        break;
                }

                break;
            case 3:
                switch (currentPiecesOfTreasure)
                {
                    case 0:
                        SceneManager.LoadScene(4);
                        break;
                    case 1:
                        SceneManager.LoadScene(5);
                        break;
                    case 2:
                        SceneManager.LoadScene(6);
                        break;
                    case 3:
                        SceneManager.LoadScene(2);
                        break;
                    case 4:
                        SceneManager.LoadScene(3);
                        break;
                }
                break;
            case 4:
                switch (currentPiecesOfTreasure)
                {
                    case 0:
                        SceneManager.LoadScene(5);
                        break;
                    case 1:
                        SceneManager.LoadScene(6);
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
            case 5:
                switch (currentPiecesOfTreasure)
                {
                    case 0:
                        SceneManager.LoadScene(6);
                        break;
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
        }

    }

	public void AddOneToCurrentPiece ()
	{
		currentPiecesOfTreasure += 1;
	}

    public void WinningState()
    {
		if(currentPiecesOfTreasure == 5 && loadOnce == false)
        {
			loadOnce = true;
			SceneManager.LoadScene(7);
            finalReward.SetActive(true);
        }
    }


}
