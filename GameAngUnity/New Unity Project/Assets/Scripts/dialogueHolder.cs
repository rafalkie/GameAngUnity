using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {


	public string dialogue;
	public string wrongDialogue;
	private DialogueManager dMan;

	public string[] dialogueLines;
	public string[] wrongLines;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (scoreManager.score == 5) {
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
