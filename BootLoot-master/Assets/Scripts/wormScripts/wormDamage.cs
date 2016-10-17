using UnityEngine;
using System.Collections;

public class wormDamage : MonoBehaviour {

	[SerializeField]
	private GameObject damageColl;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "feet") {
			damageColl.SetActive (true);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		damageColl.SetActive (false);
	}
}
