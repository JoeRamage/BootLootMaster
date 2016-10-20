using UnityEngine;
using System.Collections;

public class coinCollect : MonoBehaviour {

	[FMODUnity.EventRef]
	public string collect = "event:/sfx/coin";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			GameObject.Find("Globals(Clone)").GetComponent<globals>().coinTotal = GameObject.Find("Globals(Clone)").GetComponent<globals>().coinTotal + 1;
			FMODUnity.RuntimeManager.PlayOneShot (collect);
			Destroy (transform.parent.gameObject);
		}
	}
}
