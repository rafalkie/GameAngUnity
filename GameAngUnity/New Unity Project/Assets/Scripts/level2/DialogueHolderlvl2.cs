using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolderlvl2 : MonoBehaviour {

	public string dialog;
	public string dialog1;
	public string dialog2;
	public string dialog3;


	private DialogueManagerlvl2 dMan;

	public string[] dialogueLines;
	public string[] wrongLines;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManagerlvl2> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (scoreManager.score == 6) {
			if (other.gameObject.name == "character") {
				if (Input.GetKeyUp (KeyCode.Return)) {
					if (!dMan.dialogActive) 
					{
						dMan.dialogLines = dialogueLines;
						dMan.currentLine = 0;
						dMan.ShowDialog ();
					}
				}	
			}

		} else {
			if (other.gameObject.name == "character") {
				if (Input.GetKeyUp (KeyCode.Return)) {
					if (!dMan.dialogActive) 
					{
						dMan.dialogLines = wrongLines;
						dMan.currentLine = 0;
						dMan.ShowDialog ();
					}
				}
			}
		}
	}
}
