using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager2 : MonoBehaviour {
	public GameObject currentCheckPoint;
	private playerControler player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playerControler> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer(){		
		if(Input.GetKeyDown (KeyCode.Alpha2))
			player.transform.position = currentCheckPoint.transform.position;


	}
}
