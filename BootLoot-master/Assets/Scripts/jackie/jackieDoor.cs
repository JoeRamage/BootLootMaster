using UnityEngine;
using System.Collections;

public class jackieDoor : MonoBehaviour {

	[SerializeField]
	private GameObject indicator; 
	public bool overJackieDoor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			indicator.SetActive (true);
			overJackieDoor = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if(other.tag == "Player") {
			indicator.SetActive (false);
			overJackieDoor = false;
		}
	}
}
