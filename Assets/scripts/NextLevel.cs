using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public string nextScene;

	//Trigger Collision
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player")
			Application.LoadLevel(nextScene);
	}

	public void LoadLevel (string levelName) {
		Application.LoadLevel(levelName);
	}
}
