﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagerlvl4npc1 : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
	private QuestDialogManagerlvl4npc1 dQuest;

	public string[] dialogLines;
	public int currentLine;

	public bool dialogActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (dialogActive && Input.GetKeyDown(KeyCode.Return))
		{
			currentLine++;
		}
		if (currentLine >= dialogLines.Length) 
		{
			dBox.SetActive (false);
			dialogActive = false;
			if(scoreManager.score == 9){
				dQuest.dialogActive = true;
				dQuest.dQuest.SetActive (true);
			}


			currentLine = 0;
		}

		dText.text = dialogLines [currentLine];
		dQuest = FindObjectOfType<QuestDialogManagerlvl4npc1> ();
	}




	public void ShowBox(string dialogue)
	{
		dialogActive = true;
		dBox.SetActive (true);
		dText.text = dialogue;
	}

	public void ShowDialog(){
		dialogActive = true;
		dBox.SetActive (true);
	}
}