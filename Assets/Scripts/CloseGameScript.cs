﻿using UnityEngine;
using System.Collections;

public class CloseGameScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	
	}
}
