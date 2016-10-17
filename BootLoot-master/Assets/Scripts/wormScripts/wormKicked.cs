using UnityEngine;
using System.Collections;

public class wormKicked : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "kickColl") {
			//GameObject.Find ("newWorm").GetComponent<newWorm> ().newWormAnimator.SetBool ("sucked", false);
			GameObject.Find ("worm").GetComponent<newWorm> ().newWormAnimator.SetTrigger ("dead");
		}
		//if (other.tag == "Player") {
		//	GameObject.Find ("controllerCollider").GetComponent<Player> ().spikerHurt ();
		//}
	}
}
