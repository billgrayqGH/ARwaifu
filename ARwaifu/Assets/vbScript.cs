using UnityEngine;
using System.Collections;
using Vuforia;
public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("actionButton");
		zombie = GameObject.Find ("zombie");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){

		Debug.Log("button down!!!");
		zombie.GetComponent<Animation> ().Play();
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

		Debug.Log ("button released");
		zombie.GetComponent<Animation> ().Stop();
	}

}