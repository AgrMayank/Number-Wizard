using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int min;
	int max;
	int guess;

	void Start () {

		StartGame();

	}

	void StartGame()
	{

		max = 1000;
		min = 1;
		guess = 500;

		print("###################################################");
		print("Welcome to Number Wizard");
		print("Pick a number in your head but don't tell me!");

		print("The Highest Number you can pick is " + max);
		print("The Lowest Number you can pick is " + min);

		print("Is the number higher than " + guess + " ??");
		print("Press UP arrow = Higher, DOWN arrow = Lower, return = Equal");

		max = max + 1;

	}

	void NextGuess()
	{

		guess = (max + min) / 2;
		print("Higher or Lower than " + guess);
		print("Press UP arrow = Higher, DOWN arrow = Lower, return = Equal");

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			//print("Up Arrow Pressed !");
			min = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			//print("Down Arrow Pressed !");
			max = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print("I Won !");
			Start();
		}
	}
}
