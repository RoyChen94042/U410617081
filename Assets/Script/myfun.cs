﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myfun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gogame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void exitgame()
    {
        Application.Quit();
    }
}
