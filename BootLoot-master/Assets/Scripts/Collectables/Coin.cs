using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 endPos;

	private bool beingSucked;

	[SerializeField]
	private Transform coinTrans;
	[SerializeField]
	private Transform endTrans;

	public float speed;

	[SerializeField]
	private float animationWaitTime; 

	// Use this for initialization
	void Start () {
		StartCoroutine (AnimationTimer ());
		coinTrans = gameObject.transform;
		endTrans = GameObject.Find ("Player").GetComponent<Transform> ().transform;
	}
	
	// Update is called once per frame
	void Update () {
		startPos = coinTrans.position;

		endPos = endTrans.position + new Vector3 (0, 2, 0);
	}

	IEnumerator AnimationTimer() {
		yield return new WaitForSeconds (animationWaitTime);
		gameObject.GetComponent<Animator>().enabled = true;
	}

	public void PlayerCollect() {
		
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "collSuck" && GameObject.Find ("Globals(Clone)").GetComponent<globals> ().powerOn) {
			StartCoroutine (coinSuckTimer ());
			beingSucked = true;
		} else {
			beingSucked = false;
		}
	}

	private IEnumerator coinSuckTimer() {
		yield return new WaitForSeconds(0.25f);
		coinTrans.localPosition = Vector3.MoveTowards (coinTrans.localPosition, endPos, speed * Time.deltaTime);
	}
}
