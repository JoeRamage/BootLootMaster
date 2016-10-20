using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class jackieInDoor : MonoBehaviour {

	[SerializeField]
	private GameObject indicator;
	private bool overJackieInDoor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (overJackieInDoor && Input.GetKeyDown (KeyCode.T)) {
			SceneManager.LoadScene ("mainMap");
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			indicator.SetActive (true);
			overJackieInDoor = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if(other.tag == "Player") {
			indicator.SetActive (false);
			overJackieInDoor = false;
		}
	}
}
