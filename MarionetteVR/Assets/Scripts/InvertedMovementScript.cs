using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedMovementScript : MonoBehaviour {
//	[SerializeField] Transform target;

	public GameObject actualInteractable;

	public float multiplier;


	Vector3 firstPos;
//	Vector3 targetPos;

	// Use this for initialization
	void Start () {
		
		transform.position = actualInteractable.transform.position;

		firstPos = transform.position;

//		targetPos = target.position;
	}
	
	// Update is called once per frame
	void Update () {
//		float dist = Mathf.Abs(Vector3.Distance(transform.position, targetPos));

//		Vector3 direction = transform.position - targetPos;
//		float distX = Mathf.Abs(transform.position.x - targetPos.x);
//		float distY = Mathf.Abs(transform.position.y - targetPos.y);
//		float distZ = Mathf.Abs (transform.position.y - targetPos.y);
//
//		target.position = new Vector3 (transform.position.x - distX, transform.position.y - distY, transform.position.z - distZ)  ;
//		actualInteractable.transform.position = new Vector3 (firstPos.x + (firstPos.x + transform.position.x) * multiplier, firstPos.y + (firstPos.y + transform.position.y) * multiplier, firstPos.z + (firstPos.z + transform.position.z) * multiplier);

//		target.position = transform.position * -1f;
		if (actualInteractable.tag == "ArmHandle") {

			actualInteractable.transform.position = new Vector3 (transform.position.x * multiplier, transform.position.y * multiplier, transform.position.z * multiplier);
		}

		if (actualInteractable.tag == "LegHandle") {
			actualInteractable.transform.position = new Vector3 (firstPos.x + (firstPos.x - transform.position.x) * multiplier, firstPos.y + (firstPos.y - transform.position.y) * multiplier, firstPos.z + (firstPos.z - transform.position.z) * multiplier);

		}


	}
}
