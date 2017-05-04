using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickChange : MonoBehaviour
{

    public GameObject activatingObject;

    public GameObject panel;
    public GameObject[] text;
    public GameObject AllUI;

    public int count = 0;
    // Use this for initialization

    void Start()
    {
        panel.SetActive(false);
        AllUI.SetActive(false);
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

        if (activatingObject.GetComponent<Renderer>().enabled == true)
        {
            AllUI.SetActive(true);
        }

        /* For future development, If scene is changed or sth else
        else if ()
        {
            AllUI.SetActive(false);
        }
        */

        if (count != 3)
        {

            panel.SetActive(true);
            text[count].SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
