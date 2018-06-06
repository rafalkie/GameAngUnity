using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer2 : MonoBehaviour {

	public LevelManager2 levelManager2;
	// Use this for initialization
	void Start () {
		levelManager2 = FindObjectOfType<LevelManager2> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.name == "character") {
			levelManager2.RespawnPlayer();
		}
	}
}
