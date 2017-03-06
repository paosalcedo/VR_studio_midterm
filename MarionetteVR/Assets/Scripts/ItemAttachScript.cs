using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAttachScript : MonoBehaviour {
	GameObject buddy;
	
	// Use this for initialization
	void Start () {
		buddy = GameObject.Find("BuddyRagdoll");	
	}
	
	// Update is called once per frame
	void Update () {
		ItemAttachUpdate ();		
	}

	void ItemAttachUpdate ()
	{
		GameObject other;
		other = GameObject.Find ("SampleItem");
		float dist;
		dist = Vector3.Distance(other.transform.position, buddy.transform.position);

		if (dist < 1f) {			
				if (other.gameObject.tag == "Head") {
					Transform newParent;
					newParent = GameObject.Find ("HEAD_BUDDY").GetComponent<Transform> ();
					other.transform.SetParent (newParent);
					other.transform.position = newParent.transform.position;
					other.transform.rotation = newParent.transform.rotation; 
					other.GetComponent<Rigidbody> ().isKinematic = true; 
				}
			}
		}
}
