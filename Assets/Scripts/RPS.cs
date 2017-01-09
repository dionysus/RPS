using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPS : MonoBehaviour {

	public Text AiPlayText;
	public Text AIReaction;

	public Text Score;

	public Text RockButton;
	public Text PaperButton;
	public Text ScissorsButton;

	int WinCount;
	int LossCount;
	int DrawCount;

	int AIplay;

	//ROCK = 0
	//PAPER = 1
	//SCISSORS = 2

	// Use this for initialization
	void Start () {

		WinCount = 0;
		LossCount = 0;
		DrawCount = 0;

		gameScore ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AIplayer () {

		AIplay = Random.Range (0, 3);

		if (AIplay == 0) {

			AiPlayText.text = "Rock!";

		} else if (AIplay == 1) {

			AiPlayText.text = "Paper!";
			
		} else if (AIplay == 2) {

			AiPlayText.text = "Scissors!";

		}
			
			
	}


	public void playRock(){

		Debug.Log ("played rock!");

		AIplayer ();
		ButtonReset ();

		if (AIplay == 0) 		{gameDraw (); 	RockButton.color = Color.yellow;}
		else if (AIplay == 2) 	{gameWin(); 	RockButton.color = Color.green;}
		else if (AIplay == 1) 	{gameLose (); 	RockButton.color = Color.red;}

	}

	public void playPaper(){
		
		Debug.Log ("played paper!");

		AIplayer ();
		ButtonReset ();

		if (AIplay == 1) 		{gameDraw ();	PaperButton.color = Color.yellow;}
		else if (AIplay == 0) 	{gameWin();		PaperButton.color = Color.green;}
		else if (AIplay == 2) 	{gameLose ();	PaperButton.color = Color.red;}

	}


	public void playScissors(){

		Debug.Log ("played scissors!");

		AIplayer ();
		ButtonReset ();

		if (AIplay == 2) 		{gameDraw (); 	ScissorsButton.color = Color.yellow;}
		else if (AIplay == 1) 	{gameWin();		ScissorsButton.color = Color.green;}
		else if (AIplay == 0) 	{gameLose ();	ScissorsButton.color = Color.red;}

	}


	void gameDraw(){

		++DrawCount;

		AIReaction.text = "[~_~]";
		AIReaction.color = Color.yellow;
		AiPlayText.color = Color.yellow;

		gameScore ();

	}

	void gameWin(){
	
		++ WinCount;

		AIReaction.text = "[>_<]";
		AIReaction.color = Color.red;
		AiPlayText.color = Color.red;

		gameScore ();

	}

	void gameLose(){

		++LossCount;

		AIReaction.text = "[^_^]";
		AIReaction.color = Color.green;
		AiPlayText.color = Color.green;

		gameScore ();
	
	}

	void gameScore(){

		Score.text = WinCount + " - " + LossCount + " - " + DrawCount; 

		if (WinCount > LossCount) 		{Score.color = Color.green;}
		else if (WinCount < LossCount) 	{Score.color = Color.red;}
		else if (WinCount == LossCount) 	{Score.color = Color.yellow;}

	}

	void ButtonReset(){
	
		RockButton.color = Color.white;
		PaperButton.color = Color.white;
		ScissorsButton.color = Color.white;

	}

}
