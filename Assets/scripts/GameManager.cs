using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	int collectables;
	public Text remainingCollectables;

	// Use this for initialization
	void Start () {
		collectables = GameObject.FindGameObjectsWithTag ("Collectable").Length;
	}
	
	public void addCollectable (int amount) {
		collectables += amount;
	}

	void FixedUpdate () {

		if (remainingCollectables)
			remainingCollectables.text = "Collectable left: " + collectables;
	}
}
