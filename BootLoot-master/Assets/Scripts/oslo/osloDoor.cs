using UnityEngine;
using System.Collections;

public class osloDoor : MonoBehaviour {

	[SerializeField]
	private GameObject indicator; 
	public bool overOsloDoor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			indicator.SetActive (true);
			overOsloDoor = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if(other.tag == "Player") {
			indicator.SetActive (false);
			overOsloDoor = false;
		}
	}
}
