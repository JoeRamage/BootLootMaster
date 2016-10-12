using UnityEngine;
using System.Collections;

public class PlayerFeet : MonoBehaviour {

	[SerializeField]
	private float terrainType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if(other.tag == "tWater") {
			terrainType = 0.50f;
		}
		if(other.tag == "tGrass") {
			terrainType = 1.50f;
		}
		if(other.tag == "tWood") {
			terrainType = 2.50f;
		}
		if(other.tag == "tDirt") {
			terrainType = 3.50f;
		}
	}
}
