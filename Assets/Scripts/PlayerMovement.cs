using UnityEngine;
 using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float forceApplied = 20f; //force added to the player
	public Rigidbody rb; //player
	public float forwardForce = 1000f; //for the player to move forward when game starts

	//update is called once per physics update
	void FixedUpdate() {
		//what key did the user press?
		//move forward
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		//move right
		if(Input.GetKey("d")) {
      Debug.Log("D clicked!");
			rb.AddForce(forceApplied * Time.deltaTime, 0, 0);
		}
		//move left
		if(Input.GetKey("a")) {
      Debug.Log("A clicked!");
			rb.AddForce(-forceApplied * Time.deltaTime, 0, 0);
		}

	}
}
