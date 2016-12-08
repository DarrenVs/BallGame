using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	Transform cam;
	float jumpCooldown = 0;

	int colliding = 0;

	// Use this for initialization
	void Start () {
		cam = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		cam = GameObject.FindGameObjectWithTag ("MainCamera").transform;
	}

	// Colission
	void OnCollisionEnter (Collision col)
	{
		++colliding;
	}
	void OnCollisionExit (Collision col)
	{
		--colliding;
	}
	
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Respawn")
			Application.LoadLevel (Application.loadedLevel);
	}

	void FixedUpdate() {
		jumpCooldown -= Time.deltaTime;
		if (jumpCooldown <= 0 && colliding > 0 && Input.GetButtonDown ("Jump")) {
			GetComponent<Rigidbody>().AddForce (new Vector3 (0, 250, 0));
			jumpCooldown = 1;
		}

		float xInput = Input.GetAxis ("Horizontal");
		float zInput = Input.GetAxis ("Vertical");

		if (colliding>0) GetComponent<Rigidbody>().AddForce ((Vector3.right * xInput + Vector3.forward * zInput) * moveSpeed);


		cam.parent.Rotate ( -cam.parent.eulerAngles + (-Vector3.right * zInput + Vector3.forward * xInput) * 11.25f );
	}
}
