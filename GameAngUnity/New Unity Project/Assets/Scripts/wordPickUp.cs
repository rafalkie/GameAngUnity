using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordPickUp : MonoBehaviour {

	public int pointsToAdd;

	public AudioSource wordSoundEffect;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<playerControler> () == null)
			return;

		scoreManager.AddPoints (pointsToAdd);

		wordSoundEffect.Play ();

		Debug.Log ("Zebrane");

		Destroy (gameObject);
	}
}
