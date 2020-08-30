using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{

    private float timer = 30f;
    public Text timerUI;

    // Start is called before the first frame update
    void Start()
    {

        timerUI = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerUI.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene("NextLevel");
        }
    }
}
