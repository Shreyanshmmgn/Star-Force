﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void replay()
    {
        SceneManager.LoadScene("HelloAR");
    }
    public void quit()
    {
        Application.Quit();
    }
  
}
