﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
	}
}