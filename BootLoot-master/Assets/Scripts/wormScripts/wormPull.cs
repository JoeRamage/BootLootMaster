using UnityEngine;
using System.Collections;

public class wormPull : MonoBehaviour {

	[SerializeField]
	private GameObject headTrigAreaColl;
	[SerializeField]
	private GameObject damageTrigAreaColl;
	[SerializeField]
	private GameObject wormPullTrigger;

	public Vector3 startPos;
	public Vector3 endPos;

	public bool beingSucked;

	[SerializeField]
	private Transform wormTrans;
	[SerializeField]
	private Transform endTrans;

	public float speed;

	//[SerializeField]
	//private float animationWaitTime; 

	// Use this for initialization
	void Start () {
		endTrans = GameObject.Find ("collEndTrans").transform;
	}
	
	// Update is called once per frame
	void Update () {
		startPos = wormTrans.position;

		endPos = endTrans.position - new Vector3 (0, 2f, 0);
	}

	void OnTriggerStay2D (Collider2D other) {
		if (GameObject.Find ("Globals").GetComponent<globals> ().powerOn == true) {
			StartCoroutine (wormSuckTimer ());
			beingSucked = true;
			headTrigAreaColl.SetActive (false);
			damageTrigAreaColl.SetActive (false);
			wormPullTrigger.SetActive (true);
			GameObject.Find ("newWorm").GetComponent<newWorm> ().newWormRigidBody.gravityScale = 0;
		} else {
			beingSucked = false;
			headTrigAreaColl.SetActive (true);
			damageTrigAreaColl.SetActive (true);
			wormPullTrigger.SetActive (false);
			GameObject.Find ("newWorm").GetComponent<newWorm> ().newWormRigidBody.gravityScale = 7;
		}
	}

	private IEnumerator wormSuckTimer() {
		yield return new WaitForSeconds(0);
		wormTrans.localPosition = Vector3.MoveTowards (wormTrans.localPosition, endPos, speed * Time.deltaTime);
	}
}
