using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordPickUp : MonoBehaviour {

	public int pointsToAdd;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<playerControler> () == null)
			return;

		scoreManager.AddPoints (pointsToAdd);

		Destroy (gameObject);
	}
}
