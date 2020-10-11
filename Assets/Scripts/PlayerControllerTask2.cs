using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTask2 : MonoBehaviour {

	public float movespeed;
	public float maxspeed;
	public float jumpforce;

	int FloorLayer;
	Transform playerFeetCollider;

	Rigidbody2D playerRB;

	//TASK 2
	public bool feetContact;

	void Awake() {
		FloorLayer = LayerMask.NameToLayer ("Floor");
		playerRB = gameObject.GetComponent<Rigidbody2D> ();

	}

	void Update () {
		float MoveHor = Input.GetAxisRaw ("Horizontal");
		Vector2 movement = new Vector2 (MoveHor * movespeed, 0);
		movement = movement * Time.deltaTime;

		//Debug.Log("feet contact: " + feetContact.ToString());

		playerRB.AddForce(movement);
		if (playerRB.velocity.x > maxspeed) {
			playerRB.velocity = new Vector2 (maxspeed, playerRB.velocity.y);
		}
		if (playerRB.velocity.x < -maxspeed) {
			playerRB.velocity = new Vector2 (-maxspeed, playerRB.velocity.y);
		}
		if (Input.GetKeyDown(KeyCode.W) && canJump()) {
			playerRB.velocity = new Vector2 (playerRB.velocity.x, 0);
			playerRB.AddForce ( new Vector2(0, jumpforce));
		}

	}

	bool canJump() {
        //return false;
		//TASK 2
		return feetContact;
	}
}
