using UnityEngine;
using System.Collections;

public class wormDead : MonoBehaviour {

	[SerializeField]
	private GameObject coinSpawn;
	[SerializeField]
	private Transform coinSpawnPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void wormDeadFunc() {
		Debug.Log ("called wormDeadFunc");
		GameObject coinSpawner = (GameObject)Instantiate (coinSpawn, coinSpawnPos.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
		Destroy (transform.parent.gameObject, 1f);
	}
}
