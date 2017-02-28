using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSupport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void KinematicOn() {
		Rigidbody rb;
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = true;
    }

	void KinematicOff (){
		Rigidbody rb;
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = false;
	}

    void DisableRagdoll() {
        BroadcastMessage("KinematicOn");
    }

	void EnableRagdoll(){
		BroadcastMessage("KinematicOff");
	}
}
