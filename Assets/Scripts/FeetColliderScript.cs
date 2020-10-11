using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetColliderScript : MonoBehaviour {
	bool feetContact;
	// Returns whether the obj is a floor, platform, or wall
	bool isFloor(GameObject obj) {
		return obj.layer == LayerMask.NameToLayer ("Floor");
	}

    // use coll.gameObject if you need a reference coll's GameObject
	void OnCollisionEnter2D(Collision2D coll) {
        //TASK 2
		Debug.Log("Entering");
		GetComponentInParent<PlayerControllerTask2>().feetContact = true;
		Debug.Log("feet contact:" + feetContact.ToString());
	}

	void OnCollisionExit2D(Collision2D coll) {
        //TASK 2
		Debug.Log("Exiting");
		GetComponentInParent<PlayerControllerTask2>().feetContact = false;
		Debug.Log("feet contact:" + feetContact.ToString());
    }

	//IF YOU NEED TO SET A PUBLIC VARIABLE IN A PARENT (hint hint)
	//GetComponentInParent<PlayerControllerTask2>().variable_name
}
