using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleLimbControl : MonoBehaviour {

	public GameObject[] parts;

	GameObject handleUp, handleDown;

	string main = "MainHandle", leftArm = "Left Elbow Stick", rightArm = "Right Elbow Stick", leftLeg = "Left Knee Stick", rightLeg = "Right Knee Stick";

	Transform attached;

//	bool isAttached = false;


	void Start () {
		attached = this.transform; //Stores the transform with the instance of this script
	}

	void Update () {
//		Debug.Log (attached.name + " Attached");

		if (handleUp != null){
			handleUp.transform.position = (parts[2].transform.position + parts[3].transform.position) / 2;   // position the sphere between the handles
		}

		if (handleDown != null){
			handleDown.transform.position = (parts[0].transform.position + parts[1].transform.position) / 2;   // position the sphere between the handles
		}
	}

	public void IdentifyAttached(){
		
//		Debug.Log (attached.name + " Grabbed");

		// Not the best approach but method gets called when a handle is grabbed
		// When Main Handle is grabbed, all other handles become its children (doing it in script as oppose to Editor heirarchy)

		if (attached.name == main) {
			Debug.Log (attached.name + " Grabbed");

			for (int i = 0; i < parts.Length; i++) {
				parts [i].transform.SetParent (attached);
			}
		}

		// Creating the 'Double Handle' when sticks are grabbed


//		if (attached.name == leftArm || attached.name == rightArm) {
//			handleUp = Instantiate(Resources.Load("Double Handle") as GameObject);
//			handleUp.transform.position = (parts[2].transform.position + parts[3].transform.position) / 2;
//		}
//
//		if (attached.name == leftLeg || attached.name == rightLeg) {
//			handleDown = Instantiate(Resources.Load("Double Handle") as GameObject);
//			handleDown.transform.position = (parts[0].transform.position + parts[1].transform.position) / 2;
//		}
//
//		if (handleUp != null && attached == handleUp.transform) {
//			for (int i = 2; i < parts.Length; i++) {
//				parts [i].transform.SetParent (attached);
//			}
//			isAttached = true;
//		}
//
//		if (handleDown != null && attached == handleDown.transform) {
//			for (int i = 3; i < parts.Length; i++) {
//				parts [i].transform.SetParent (attached);
//			}
//			isAttached = true;
//		}
	}

	public void IdentifyDetached(){
//		Debug.Log (attached.name + " Released");

		if (attached.name == main) {
			Debug.Log (attached.name + " Released");

			for (int i = 0; i < parts.Length; i++) {
				parts [i].transform.parent = null;
			}
		}

//		if (attached.name == leftArm || attached.name == rightArm) {
//			if (!isAttached) {
//				Destroy (handleUp);
//			}
//		}
//
//		if (attached.name == leftLeg || attached.name == rightLeg) {
//			if (!isAttached) {
//				Destroy (handleDown);
//			}
//		}
//
//		if (handleUp != null && attached == handleUp.transform) {
//			for (int i = 2; i < parts.Length; i++) {
//				parts [i].transform.parent = null;
//			}
//			isAttached = false;
//		}
//
//		if (handleDown != null && attached == handleDown.transform) {
//			for (int i = 3; i < parts.Length; i++) {
//				parts [i].transform.parent = null;
//			}
//			isAttached = false;
//		}
	
	}
}
