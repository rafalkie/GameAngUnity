using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour {

	public string dialogue;
	public string wrongDialogue;
	private DialogueManager dMan;

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
					dMan.ShowBox (dialogue);
				}
			}
		} else {
			if (other.gameObject.name == "character") {
				if (Input.GetKeyUp (KeyCode.Return)) {
					dMan.ShowBox (wrongDialogue);
				}
			}
		}
	}
}
