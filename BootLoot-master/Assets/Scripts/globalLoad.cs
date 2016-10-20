using UnityEngine;
using System.Collections;

public class globalLoad : MonoBehaviour {
	
	public GameObject globalPreF;
	public GameObject audiZonePreF;

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("Globals(Clone)") == null) {
			GameObject globPre = (GameObject)Instantiate (globalPreF, new Vector3 (0, 0, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
		}
		if (GameObject.Find ("audioZones(Clone)") == null) {
			GameObject audPre = (GameObject)Instantiate (audiZonePreF, new Vector3 (0, 0, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
