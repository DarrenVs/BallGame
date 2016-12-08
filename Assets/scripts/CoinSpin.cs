using UnityEngine;
using System.Collections;

public class CoinSpin : MonoBehaviour {

	void Start() {
		transform.position += new Vector3 (0, 1, 0);
	}

	void FixedUpdate () {
		transform.Rotate (new Vector3 (Random.value, Random.value, Random.value));
	}
}
