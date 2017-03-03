using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class GripScript : MonoBehaviour {


	public GameObject[] parts; 

	private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;

	private SteamVR_TrackedObject trackedObj;
	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input ((int)trackedObj.index); } }


	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (controller == null) {
			Debug.Log ("No Controller Detected");
		} else {
			if (controller.GetPressDown(gripButton)){
				Debug.Log ("Grip button pressed");

				for (int i = 0; i < parts.Length; i++) {
					parts [i].transform.parent = gameObject.transform;
				}
			}

			if (controller.GetPressUp(gripButton)){
				Debug.Log ("Grip button released");
				gameObject.transform.DetachChildren ();
			}
		}
	
	}
}
