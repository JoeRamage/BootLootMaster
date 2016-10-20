using UnityEngine;
using System.Collections;

public class canvasScr : MonoBehaviour {

	public GameObject podsUI;
	[SerializeField]
	private GameObject pod1out;
	[SerializeField]
	private GameObject pod1in;
	[SerializeField]
	private GameObject pod2out;
	[SerializeField]
	private GameObject pod2in;
	[SerializeField]
	private GameObject pod3out;
	[SerializeField]
	private GameObject pod3in;
	[SerializeField]
	private GameObject pod4out;
	[SerializeField]
	private GameObject pod4in;

	// Use this for initialization
	void Start () {
		podsUI = GameObject.Find ("podUI");
//		podsUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Globals(Clone)").GetComponent<globals> ().jackieVisited) {
			podsUI = GameObject.Find ("podUI");
			podsUI.SetActive (true);
		}
		if (GameObject.Find ("Globals(Clone)").GetComponent<globals> ().pod1got) {
			pod1out.SetActive (false);
			pod1in.SetActive (true);
		}
		if (GameObject.Find ("Globals(Clone)").GetComponent<globals> ().pod2got) {
			pod2out.SetActive (false);
			pod2in.SetActive (true);
		}
		if (GameObject.Find ("Globals(Clone)").GetComponent<globals> ().pod3got) {
			pod3out.SetActive (false);
			pod3in.SetActive (true);
		}
		if (GameObject.Find ("Globals(Clone)").GetComponent<globals> ().pod4got) {
			pod4out.SetActive (false);
			pod4in.SetActive (true);
		}
	}
}
