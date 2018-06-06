using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestDialogMangaerlvl5npc1 : MonoBehaviour {

	public GameObject dQuest;
	public Text qText;
	public Text qText1;
	public Text qText2;
	public Text qText3;




	public bool dialogActive;
	public string levelToLoad;
	public LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();

	}

	// Update is called once per frame
	void Update () {

		if (dialogActive && Input.GetKeyDown (KeyCode.Alpha3)) {
			dQuest.SetActive(false);
			dialogActive = false;

		}else if(dialogActive && Input.GetKeyDown (KeyCode.Alpha1)){
			dQuest.SetActive(false);
			dialogActive = false;
			levelManager.RespawnPlayer ();
		}else if(dialogActive && Input.GetKeyDown (KeyCode.Alpha2)){
			dQuest.SetActive(false);
			dialogActive = false;
			levelManager.RespawnPlayer ();
		}

	}

	public void ShowBox(string dialogue,string dialogue1, string dialogue2, string dialogue3)
	{
		dialogActive = true;
		dQuest.SetActive (true);
		qText.text = dialogue;
		qText1.text = dialogue1;
		qText2.text = dialogue2;
		qText3.text = dialogue3;
	}
}
