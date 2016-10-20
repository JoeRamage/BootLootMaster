using UnityEngine;
using System.Collections;

public class playerSounds : MonoBehaviour {

	public bool landed = false; 

	[FMODUnity.EventRef]
	public string footsteps = "event:/playersfx/footsteps";
	FMOD.Studio.EventInstance footstepsEv; 
	FMOD.Studio.ParameterInstance footstepsParam; 

	[FMODUnity.EventRef]
	public string landingSounds = "event:/playersfx/landing";
	FMOD.Studio.EventInstance landingSoundsEv; 
	FMOD.Studio.ParameterInstance landingSoundsParam;


	// Use this for initialization
	void Start () {

		footstepsEv = FMODUnity.RuntimeManager.CreateInstance (footsteps);
		footstepsEv.getParameter ("surfaceChange", out footstepsParam);

		landingSoundsEv = FMODUnity.RuntimeManager.CreateInstance (landingSounds);
		landingSoundsEv.getParameter ("surfaceChange", out landingSoundsParam);
	
	}
	
	// Update is called once per frame
	void Update () {

		footstepsParam.setValue (GameObject.Find("feetColl").GetComponent<PlayerFeet>().terrainType); 
		landingSoundsParam.setValue (GameObject.Find ("feetColl").GetComponent<PlayerFeet>().terrainType);

		//if (GameObject.Find ("controllerCollider").GetComponent<Player> ().isGrounded) {
			//Debug.Log ("landSounds should be playing");
			//landingSoundsEv.start ();
		//}
	}

	public void playfootsteps (){

		if (GameObject.Find ("controllerCollider").GetComponent<Player> ().isGrounded) {

			footstepsEv.start ();
		}
	}

}
