using UnityEngine;
using System.Collections;

public class worm : MonoBehaviour {

	[SerializeField]
	private Rigidbody2D wormRigidBody;
	[SerializeField]
	private Animator wormAnimator;
	[SerializeField]
	private float moveWaitTime;
	[SerializeField]
	private float moveSpeed;
	[SerializeField]
	private Vector3 direction;
	private Vector3 wormDirection;

	[SerializeField]
	private Collider2D other;
	[SerializeField]
	private Collider2D edgeCol;

	private bool moving = false;

	[SerializeField]
	private GameObject coinSpawn;
	[SerializeField]
	private Transform coinSpawnPos;

	// Use this for initialization
	void Start () {
		StartCoroutine (WormMoveTimer ());

		wormDirection = new Vector3 (-1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		direction = wormDirection;

		if (wormRigidBody.velocity.y != 0) {
			wormAnimator.SetBool ("falling", true);
		} else {
			wormAnimator.SetBool ("falling", false);
		}

	}

	void FixedUpdate() {
		if (moving) {
			transform.Translate (direction * moveSpeed);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Edge") {
			StartCoroutine (EdgeColliderIgnoreTimer ());
			transform.localScale = new Vector3(transform.localScale.x * -1, 2, 1);
		}

		//if (other.tag == "feet") {
		//	wormAnimator.SetTrigger ("death");
		//}
	}

	IEnumerator WormMoveTimer() {
		yield return new WaitForSeconds (moveWaitTime);
		wormAnimator.SetBool ("moving", true);
		moving = true;
	}

	IEnumerator EdgeColliderIgnoreTimer() {
		Physics2D.IgnoreCollision(edgeCol, other, true);
		yield return new WaitForSeconds (2);
		Physics2D.IgnoreCollision(edgeCol, other, false);
	}

	public void wormDead() {
		GameObject coinSpawner = (GameObject)Instantiate (coinSpawn, coinSpawnPos.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
		Destroy (gameObject);
	}
}
