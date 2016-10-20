using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	public float musicState = 0.5f;

	[FMODUnity.EventRef]
	public string musicAdapt = "event:/music/musicAdapt"; 
	FMOD.Studio.EventInstance musicAdaptEv; 
	FMOD.Studio.ParameterInstance musicAdaptParam;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	void Start () {
	
		musicAdaptEv = FMODUnity.RuntimeManager.CreateInstance (musicAdapt);
		musicAdaptEv.getParameter ("adapt", out musicAdaptParam);
		musicAdaptEv.start (); 
	}
	
	// Update is called once per frame
	void Update () {
	
		musicAdaptParam.setValue (musicState);
	}
}
