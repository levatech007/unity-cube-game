using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	//reference to the player position
	public Transform player;
	public Vector3 offset;
	// Update is called once per frame
	void Update () {
		//set camera position to player position
		transform.position = player.position + offset;
	}
}
