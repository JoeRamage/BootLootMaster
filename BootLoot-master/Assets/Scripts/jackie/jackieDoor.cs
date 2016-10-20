using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class jackieDoor : MonoBehaviour {

	[SerializeField]
	private GameObject indicator; 
	public bool overJackieDoor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (overJackieDoor && Input.GetKeyDown (KeyCode.T)) {
			SceneManager.LoadScene ("jackieHouse");
		}
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
