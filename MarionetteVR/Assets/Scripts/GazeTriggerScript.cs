﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GazeTriggerScript : MonoBehaviour {


	[SerializeField] float timeLookedAt = 0f; // Time in secs we spent looking at thing
	[SerializeField] Image progressImage; // assign in the inspector
	[SerializeField] float angleTrigger;
	[SerializeField] Camera myCam;

//	public UnityEvent OnGazeComplete = new UnityEvent();

	void Update () {
		// Is the camera looking / pointing at something?
		//Get direction user is looking
		Vector3 camLookDir = myCam.transform.forward;
		// Direction from player to the target object (A to B = B-A)
		Vector3 vectorFromCameraToTarget = transform.position - myCam.transform.position;

		Debug.Log ("Camera direction: " + vectorFromCameraToTarget);

		// get angle between look direction and object's direction
		float Angle = Vector3.Angle(camLookDir, vectorFromCameraToTarget);

		//do stuff based on that angle
		if (Angle < angleTrigger) {
			timeLookedAt = Mathf.Clamp01 (timeLookedAt + Time.deltaTime); //After 1sec this variable will be one

			if (timeLookedAt == 1f) {
				timeLookedAt = 0f;
				SceneManager.LoadScene ("Hosni_01032017");

//				OnGazeComplete.Invoke (); //Fire associated events

			}


		} else {
			// Decay progress if we are not looking at it
			timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);

		}

		//update our UI image
		progressImage.fillAmount = timeLookedAt;
	}
}