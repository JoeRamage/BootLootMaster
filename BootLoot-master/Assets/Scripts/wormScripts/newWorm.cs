using UnityEngine;
using System.Collections;

public class newWorm : MonoBehaviour {


	public Rigidbody2D newWormRigidBody;
	public Animator newWormAnimator;

	[SerializeField]
	private float moveWaitTime;
	[SerializeField]
	public float moveSpeed;
	[SerializeField]
	private Vector3 direction;
	[SerializeField]
	private Vector3 wormDirection;
	[SerializeField]
	private bool facingRight = false;

	private bool moving = false;

	[SerializeField]
	private Collider2D other;
	[SerializeField]
	private Collider2D edgeCol;

	[SerializeField]
	private GameObject coinSpawn;
	[SerializeField]
	private Transform coinSpawnPos;



	void Start () {
		StartCoroutine (WormMoveTimer ());
		wormDirection = new Vector3 (-1, 0, 0);
	}
	
	void Update () {
		
		direction = wormDirection;

		if (newWormRigidBody.velocity.y != 0) {
			newWormAnimator.SetBool ("falling", true);
		} else {
			newWormAnimator.SetBool ("falling", false);
		}

		if (GameObject.Find ("wormPullArea").GetComponent<wormPull> ().beingSucked == true) {
			newWormAnimator.SetBool ("sucked", true);
		} else {
			newWormAnimator.SetBool ("sucked", false);
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
			transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
			if (!facingRight) {
				facingRight = true;
			} else if(facingRight){
				facingRight = false;
			}
		}

		//if (other.tag == "feet") {
		//	newWormAnimator.SetTrigger ("death");
		//}
	}

	IEnumerator EdgeColliderIgnoreTimer() {
		Physics2D.IgnoreCollision(edgeCol, other, true);
		yield return new WaitForSeconds (2);
		Physics2D.IgnoreCollision(edgeCol, other, false);
	}

	IEnumerator WormMoveTimer() {
		yield return new WaitForSeconds (moveWaitTime);
		newWormAnimator.SetBool ("moving", true);
		moving = true;
	}
}
