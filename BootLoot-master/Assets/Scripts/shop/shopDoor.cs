using UnityEngine;
using System.Collections;

public class shopDoor : MonoBehaviour {

	[SerializeField]
	private GameObject indicator; 
	public bool overShopDoor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			indicator.SetActive (true);
			overShopDoor = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if(other.tag == "Player") {
			indicator.SetActive (false);
			overShopDoor = false;
		}
	}
}
