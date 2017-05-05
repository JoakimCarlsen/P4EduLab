using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChange : MonoBehaviour
{

    public GameObject panel;
    public GameObject [] text;
    public GameObject allUI;
    public CanvasGroup allUI1;
    public GameObject buttonChange;

    public static bool startGame = false;
    public int count = 0;
    // Use this for initialization

    void Start()
    {
        panel.SetActive(false);
        allUI.SetActive(false);
    }

    public void ChangeTextPage()
    {
        count++;
        if (count < 2)
        {
            
            text[count].SetActive(true);
        }
        if (count != 0)
        {
            text[count - 1].SetActive(false);
        }


    }

    public void GetHelp()
    {
        if (count == 3)
        {
            count = 0;
            panel.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 3)
        {
            allUI1.alpha -= Time.deltaTime / 2;
            buttonChange.SetActive(false);
            startGame = true;
        }
        if (around.clicked == true && count !=3)
        {
            
            allUI.SetActive(true);
            panel.SetActive(true);
            allUI1.alpha += Time.deltaTime / 2;
        }
    }
}
