using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class around : MonoBehaviour
{
    public GameObject island;

    public CanvasGroup logo;
    public CanvasGroup buttonAni;
    public CanvasGroup buttonGame;
    public GameObject buttonGame1;
    

    public float speed;
    public float max;
    public float t;
    float speed2;
    public static bool clicked = false;

    // Use this for initialization
    void Start()
    {
        buttonGame1.SetActive(false);
    }
    private void Update()
    {
        if (MenuChange.startGame == true)
        {
            buttonGame1.SetActive(true);
            buttonGame.alpha += Time.deltaTime / 2;
        }

        if (clicked == true)
        {
            Orbit();
        }
    }

    void Orbit()
    {
        buttonAni.alpha -= Time.deltaTime / 2;
        
        logo.alpha -= Time.deltaTime / 2;

        t += 0.9f * Time.deltaTime;
        speed = Mathf.Lerp(0, max, t);

        transform.RotateAround(island.transform.position, Vector3.up, speed * Time.deltaTime);
    }

    public void tickYes()
    {
        clicked = true;
    }
}