using UnityEngine;
using System.Collections;

public class wormHeadTrig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "feet") {
			GameObject.Find("worm").GetComponent<newWorm>().newWormAnimator.SetTrigger ("dead");
			//GameObject.Find ("wormSprites").GetComponent<wormDead> ().wormDeadFunc ();
		}
	}
}
