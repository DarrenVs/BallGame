using UnityEngine;
using System.Collections;

public class SpinningBehaiviour : MonoBehaviour {

	public float speed;

	// Colission
	void OnCollisionStay (Collision col)
	{
		if (col.transform.tag == "Player")
			col.rigidbody.MoveRotation (col.rigidbody.rotation * Quaternion.Euler (col.transform.up * speed * Time.deltaTime));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().MoveRotation (GetComponent<Rigidbody>().rotation * Quaternion.Euler (transform.up * speed * Time.deltaTime));
	}
}
