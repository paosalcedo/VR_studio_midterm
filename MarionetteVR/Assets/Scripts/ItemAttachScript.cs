using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAttachScript : MonoBehaviour {

//	GameObject item_arm; // for all objects for arm/hand.
	GameObject[] items_arm; // 
//	GameObject item_head;
	GameObject[] items_head;
	GameObject[] items_foot;

	float dist;

	public float radius = 1f; 
	// Use this for initialization
	void Start () {
		items_arm = GameObject.FindGameObjectsWithTag("Item_Arm");
		items_head = GameObject.FindGameObjectsWithTag("Item_Head");
	}
	
	// Update is called once per frame
	void Update () {
		ItemAttachUpdate ();		
	}

	void ItemAttachUpdate ()
	{
		float xPos = transform.position.x;
		float yPos = transform.position.y;
		float zPos = transform.position.z;
		float xRot = transform.eulerAngles.x;
		float yRot = transform.eulerAngles.y;
		float zRot = transform.eulerAngles.z;

		foreach (GameObject item_arm in items_arm) {		
//			dist = Vector3.Distance (item_arm.transform.position, transform.position);

			//ATTACHES ITEM TO GAMEOBJECT WHEN dist IS LESS THAN radius
			if (Vector3.Distance (item_arm.transform.position, transform.position) < radius) {
				if (item_arm.gameObject.tag == "Item_Arm" &&
				    transform.parent.name == "RIGHTHAND_BUDDY" || transform.parent.name == "LEFTHAND_BUDDY") { 	
//						Debug.Log ("item is in range of right arm!");
					Transform newParent;
					newParent = GetComponent<Transform> ();
					item_arm.GetComponent<Collider> ().enabled = false;
					item_arm.GetComponent<Rigidbody> ().useGravity = false;
					item_arm.GetComponent<Rigidbody> ().isKinematic = true;
					item_arm.transform.SetParent (newParent);
					item_arm.transform.position = new Vector3 (xPos, yPos, zPos);
					item_arm.transform.localEulerAngles = new Vector3 (zRot, xRot, yRot);
					item_arm.transform.rotation = newParent.transform.rotation;
				}
//				if (dist < radius) {
//					//CHECKS IF IT'S AN ARM ITEM, THEN CHECKS IF IT'S LEFT OR RIGHT ARM
//					
//				}
			}
		}
		foreach (GameObject item_head in items_head) {
			//dist = Vector3.Distance (item_head.transform.position, transform.position);

			if (Vector3.Distance (item_head.transform.position, transform.position) < radius) {

				if (dist < radius && //CHECKS IF IT'S AN ARM, THEN CHECKS IF IT'S LEFT OR RIGHT ARM
				    item_head.gameObject.tag == "Item_Head" &&
				    transform.parent.name == "HEAD_BUDDY") { 	
//					Debug.Log ("item is in range of head!");
					Transform newParent;
					newParent = GetComponent<Transform> ();
					item_head.GetComponent<Collider> ().enabled = false;
					item_head.GetComponent<Rigidbody> ().useGravity = false;
					item_head.GetComponent<Rigidbody> ().isKinematic = true;
					item_head.transform.SetParent (newParent);
					item_head.transform.position = new Vector3 (xPos, yPos, zPos);
					item_head.transform.localEulerAngles = new Vector3 (zRot, xRot, yRot);
					item_head.transform.rotation = newParent.transform.rotation;
				}
			}
		}

		foreach (GameObject item_foot in items_foot) {
			Debug.Log ("i'm here");
		}
	}
}


