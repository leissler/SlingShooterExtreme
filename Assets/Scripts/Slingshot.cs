using UnityEngine;
using System.Collections;

public class Slingshot : MonoBehaviour {

	private GameObject launchPoint;

	void Awake() {
		Transform launchPointTrans = transform.Find("Launchpoint");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive(false);
	}

	void OnMouseEnter() {
		//print ("Slingshot:OnMouseEnter");
		launchPoint.SetActive(true);
	}

	void OnMouseExit() {
		//print ("Slingshot:OnMouseExit");
		launchPoint.SetActive(false);
	}



}
