using UnityEngine;
using System.Collections;

public class jackieHouse : MonoBehaviour {

	[SerializeField]
	private GameObject bTextBox;
	[SerializeField]
	private GameObject jTextBox;
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
	private GameObject j11;
	[SerializeField]
	private GameObject bBtn;
	[SerializeField]
	private GameObject jBtn;

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

			if(textState == 4 && tPressed) {
				StartCoroutine (jackieHouseForth());
				tPressed = false;
		}

		if(textState == 5 && tPressed) {
			StartCoroutine (jackieHouseFifth());
			tPressed = false;
		}

		if(textState == 6 && tPressed) {
			StartCoroutine (jackieHouseSixth());
			tPressed = false;
		}

		if(textState == 7 && tPressed) {
			jackieFirstTextEnd();
			tPressed = false;
		}
	}

	IEnumerator jackieHouseFirst() {
		yield return new WaitForSeconds (0.25f);
		move = true;
		yield return new WaitForSeconds (0.50f);
		move = false;
		yield return new WaitForSeconds (0.75f);
		bTextBox.SetActive (true);
		b1.SetActive (true);
		yield return new WaitForSeconds (2);
		b1.SetActive (false);
		b12.SetActive (true);
		yield return new WaitForSeconds (1);
		bBtn.SetActive (true);
		textState = 2;
	}

	IEnumerator jackieHouseSecond() {
		move = true;
		bBtn.SetActive (false);
		b12.SetActive (false);
		bTextBox.SetActive (false);
		yield return new WaitForSeconds (0.50f);
		move = false;
		bTextBox.SetActive (true);
		b3.SetActive (true);
		yield return new WaitForSeconds (0.50f);
		bBtn.SetActive (true);
		textState = 3;
	}

	IEnumerator jackieHouseThird() {
		move = true;
		bBtn.SetActive (false);
		b12.SetActive (false);
		b3.SetActive (false);
		bTextBox.SetActive (false);
		yield return new WaitForSeconds (0.50f);
		move = false;
		yield return new WaitForSeconds (0.50f);
		jTextBox.SetActive (true);
		j2.SetActive (true);
		yield return new WaitForSeconds (2f);
		j2.SetActive (false);
		j3.SetActive (true);
		yield return new WaitForSeconds (2f);
		j3.SetActive (false);
		j4.SetActive (true);
		yield return new WaitForSeconds (2f);
		jBtn.SetActive (true);
		textState = 4;
	}

	IEnumerator jackieHouseForth() {
		jBtn.SetActive (false);
		jTextBox.SetActive (false);
		j4.SetActive (false);
		bTextBox.SetActive (true);
		b2.SetActive (true);
		yield return new WaitForSeconds (2);
		b2.SetActive (false);
		b21.SetActive (true);
		yield return new WaitForSeconds (2);
		bBtn.SetActive (true);
		textState = 5;
	}

	IEnumerator jackieHouseFifth() {
		bBtn.SetActive (false);
		bTextBox.SetActive (false);
		b21.SetActive (false);
		jTextBox.SetActive (true);
		j5.SetActive (true);
		yield return new WaitForSeconds (2);
		j5.SetActive (false);
		j6.SetActive (true);
		yield return new WaitForSeconds (2);
		j6.SetActive (false);
		jTextBox.SetActive (false);
		textState = 6;
	}

	IEnumerator jackieHouseSixth() {
		jTextBox.SetActive (true);
		j7.SetActive (true);
		yield return new WaitForSeconds (2);
		j7.SetActive (false);
		j8.SetActive (true);
		yield return new WaitForSeconds (2);
		j8.SetActive (false);
		j81.SetActive (true);
		yield return new WaitForSeconds (2);
		jBtn.SetActive (true);
		textState = 7;
	}

	void jackieFirstTextEnd() {
		jTextBox.SetActive (false);
		j81.SetActive (false);
		jBtn.SetActive (false);
		textState = 8;
	}


}
