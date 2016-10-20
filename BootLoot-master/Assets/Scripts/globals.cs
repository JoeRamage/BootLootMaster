using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class globals : MonoBehaviour {

	public bool pod1got = false;
	public bool pod2got = false;
	public bool pod3got = false;
	public bool pod4got = false;

	[SerializeField]
	private GameObject textBox;

	public bool playerHurtCooldown = false;

	/*
	[SerializeField]
	private GameObject h1Obj;
	[SerializeField]
	private GameObject h2Obj;
	[SerializeField]
	private GameObject h3Obj;
	[SerializeField]
	private GameObject h4Obj;
	*/

    public int health = 5;
	public float power = 50f;
	public bool powerOn = false;
	public float powerDrainSpeed = 2;
	public float powerChargeSpeed = 2;

    public int coinTotal = 0;
	public string coinTotalString;
    public int pinkCollTotal = 0;

	public bool jackieVisited = false;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		coinTotalString = coinTotal.ToString ();


		//GameObject.Find ("coinAmountText").GetComponent<Text> ().text = coinTotalString;
		/*
		if (health == 5) {
			h4Obj.SetActive(true);
			h3Obj.SetActive(false);
			h2Obj.SetActive(false);
			h1Obj.SetActive(false);
		}
		if (health == 4) {
			h4Obj.SetActive(false);
			h3Obj.SetActive(true);
			h2Obj.SetActive(false);
			h1Obj.SetActive(false);
		}
		if (health == 3) {
			h4Obj.SetActive(false);
			h3Obj.SetActive(false);
			h2Obj.SetActive(true);
			h1Obj.SetActive(false);
		}
		if (health == 2) {
			h4Obj.SetActive(false);
			h3Obj.SetActive(false);
			h2Obj.SetActive(false);
			h1Obj.SetActive(true);
		}
		if (health == 1) {
			h4Obj.SetActive(false);
			h3Obj.SetActive(false);
			h2Obj.SetActive(false);
			h1Obj.SetActive(false);
		}
		*/

		//GameObject.Find ("power").GetComponent<RectTransform> ().sizeDelta = new Vector2 (power, 9);

		//if (!GameObject.Find ("controllerCollider").GetComponent<Player> ().hurtControlsOff) {
		//	if (power <= 50f && !powerOn) {
		//		power += Time.deltaTime * powerDrainSpeed;
		//	}
		//
		//	if (Input.GetKey (KeyCode.P) && power > 0 && power < 51 && !playerHurtCooldown) {
		//		power -= Time.deltaTime * powerChargeSpeed;
		//		powerOn = true;
		//	} else {
		//		powerOn = false;
		//	}
		//
		//	if (Input.GetKey (KeyCode.T) && power > 0 && power < 51) {
		//		textBox.SetActive (true);
		//	} else {
		//		textBox.SetActive (false);
		//	}
		//}

    }
	
}
