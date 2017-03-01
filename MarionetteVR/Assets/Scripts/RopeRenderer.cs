using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeRenderer : MonoBehaviour {

	public Transform myTarget;

	LineRenderer lr;

	// Use this for initialization
	void Start () {
		lr = gameObject.AddComponent<LineRenderer> ();
		lr.material = new Material (Shader.Find("Standard"));
		lr.widthMultiplier = 0.01f;
		lr.numPositions = 2;
	}
	
	// Update is called once per frame
	void Update () {
		lr.SetPosition (0, transform.position);
		lr.SetPosition (1, myTarget.position);
		
	}
}
