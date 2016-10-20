using UnityEngine;
using System.Collections;

public class pod1 : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 endPos;

	[SerializeField]
	private Transform podTrans;
	[SerializeField]
	private Transform endTrans;

	public float speed;

	[SerializeField]
	private Rigidbody2D pod1RigidBody;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		startPos = podTrans.position;

		endPos = endTrans.position + new Vector3 (0, 2, 0);

		if (Input.GetKeyDown (KeyCode.L)) {
			pod1move ();
		}
	}

	public void jackieGive () {
		pod1RigidBody.AddForce (new Vector2 (-200, 200));
	}

	public void pod1move() {
		gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;
		gameObject.transform.localScale = new Vector3 (0.29f, 0.29f, 0);
		podTrans.localPosition = Vector3.MoveTowards (podTrans.localPosition, endPos, 10);
	}
}
