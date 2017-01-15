﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	// Use this for initialisation
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame () {
		// Use this for initialisation
		max = 1000;
		min = 1;
		guess = 500;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");


		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the numner higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");

		// for the 1000 edge case
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
            //print("up arrow pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print("down arrow pressed");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print("I won!");
			StartGame ();
		} 
	}

	void NextGuess  () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
	}
}
