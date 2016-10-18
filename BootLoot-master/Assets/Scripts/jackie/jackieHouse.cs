using UnityEngine;
using System.Collections;

public class jackieHouse : MonoBehaviour {

	[SerializeField]
	private GameObject textBox;
	[SerializeField]
	private GameObject b1;
	[SerializeField]
	private GameObject b12;
	[SerializeField]
	private GameObject b3;
	[SerializeField]
	private GameObject j2;
	[SerializeField]
	private GameObject j3;
	[SerializeField]
	private GameObject j4;
	[SerializeField]
	private GameObject b2;
	[SerializeField]
	private GameObject b21;
	[SerializeField]
	private GameObject j5;
	[SerializeField]
	private GameObject j6;
	[SerializeField]
	private GameObject j7;
	[SerializeField]
	private GameObject j8;
	[SerializeField]
	private GameObject j81;
	[SerializeField]
	private GameObject j9;
	[SerializeField]
	private GameObject j10;
	[SerializeField]
	private GameObject b11;
	[SerializeField]
	private GameObject btn;

	[SerializeField]
	private int textState = 0;

	public float moveSpeed;
	[SerializeField]
	private Vector3 playerDirection;

	[SerializeField]
	private Vector3 direction;

	private bool move = false;

	private bool tPressed = false;

	// Use this for initialization
	void Start () {
		playerDirection = new Vector3 (-1, 0, 0);

		transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);

		StartCoroutine (jackieHouseFirst ());
	}
	
	// Update is called once per frame
	void Update () {

		direction = playerDirection;
		
		if (move) {
			transform.Translate (direction * moveSpeed);
			GameObject.Find ("controllerCollider").GetComponent<Player> ().MyAnimator.SetFloat ("Speed", 0.2f);
		}

		if(Input.GetKeyDown(KeyCode.T)) {
			tPressed = true;

			if (textState == 1 && tPressed) {
				textState = 2;
				tPressed = false;
			}
		}

			if(textState == 2 && tPressed) {
				StartCoroutine (jackieHouseSecond());
				tPressed = false;
			}

			if(textState == 3 && tPressed) {
				StartCoroutine (jackieHouseThird());
				tPressed = false;
		}
	}

	IEnumerator jackieHouseFirst() {
		yield return new WaitForSeconds (0.25f);
		move = true;
		yield return new WaitForSeconds (0.50f);
		move = false;
		yield return new WaitForSeconds (0.75f);
		textBox.SetActive (true);
		b1.SetActive (true);
		yield return new WaitForSeconds (2);
		b1.SetActive (false);
		b12.SetActive (true);
		yield return new WaitForSeconds (1);
		btn.SetActive (true);
		textState = 1;
	}

	IEnumerator jackieHouseSecond() {
		move = true;
		btn.SetActive (false);
		b12.SetActive (false);
		textBox.SetActive (false);
		yield return new WaitForSeconds (0.50f);
		move = false;
		textBox.SetActive (true);
		b3.SetActive (true);
		yield return new WaitForSeconds (0.50f);
		btn.SetActive (true);
		textState = 3;
	}

	IEnumerator jackieHouseThird() {
		move = true;
		btn.SetActive (false);
		b12.SetActive (false);
		b3.SetActive (false);
		textBox.SetActive (false);
		yield return new WaitForSeconds (0.50f);
		move = false;
		yield return new WaitForSeconds (0.50f);
		textBox.SetActive (true);
		j2.SetActive (true);
		yield return new WaitForSeconds (1f);
		j2.SetActive (false);
		j3.SetActive (true);
		yield return new WaitForSeconds (1f);
		j3.SetActive (false);
		b2.SetActive (true);
		yield return new WaitForSeconds (1f);
		b2.SetActive (false);
		b21.SetActive (true);
		yield return new WaitForSeconds (1f);
	}
}
