using UnityEngine;
using System.Collections;

public class PlayerFeet : MonoBehaviour {

	[FMODUnity.EventRef]
	public string landing = "event:/playersfx/landing";

	public bool landed = false; 

	public float terrainType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (landed == true) {
			landedSound ();
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		
		if(other.tag == "tGrass") {
			terrainType = 0.50f;
			landed = true;
		}
		if(other.tag == "tWood") {
			terrainType = 1.50f;
			landed = true;
		}
		if(other.tag == "tDirt") {
			terrainType = 2.50f;
			landed = true;
		}
	}

	void OnTriggerStay2D (Collider2D other){
		if (other.tag == "music1") {
			GameObject.Find("audioZones(Clone)").GetComponent<background>().musicState = 1.5f;
		}

		if (other.tag == "music2"){
			GameObject.Find("audioZones(Clone)").GetComponent<background>().musicState = 5.5f; 
		}

		if (other.tag == "music3") {
			GameObject.Find("audioZones(Clone)").GetComponent<background>().musicState= 6.5f;
		}

		if (other.tag == "music4") {
			GameObject.Find("audioZones(Clone)").GetComponent<background>().musicState= 7.5f;
		}
	}

	void landedSound() {
		FMODUnity.RuntimeManager.PlayOneShot (landing);
		landed = false; 
	}
}
