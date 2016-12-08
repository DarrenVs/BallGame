using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour {

	void OnTriggerEnter (Collider col) {

		if (col.CompareTag ("Player")) {

			GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ().addCollectable (-1);
			DestroyObject (this.gameObject);
		}
	}
}
