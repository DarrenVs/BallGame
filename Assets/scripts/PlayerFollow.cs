using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {

	//public Vector3 offset;

	Transform player;

	void Awake () {

		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.parent.position = player.position;
	}
}
