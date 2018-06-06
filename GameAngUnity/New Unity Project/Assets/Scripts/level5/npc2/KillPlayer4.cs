using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer4 : MonoBehaviour {

	public LevelManager4 levelManager2;
	// Use this for initialization
	void Start () {
		levelManager2 = FindObjectOfType<LevelManager4> ();	
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
