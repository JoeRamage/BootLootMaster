using UnityEngine;
using System.Collections;

public class wormHead : MonoBehaviour {

	[SerializeField]
	private GameObject headColl;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "feet") {
			Debug.Log ("Head collider is active");
			headColl.SetActive (true);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		headColl.SetActive (false);
	}
}
