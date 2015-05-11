using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public static FollowCam S; // Singleton instance of this class

	public float easing = 0.05f;

	public GameObject poi;
	private float camZ;


	

	void Awake() {
		S = this;
		camZ = transform.position.z;

	}

	void FixedUpdate() {
		// Check if the poi is empty
		if(poi == null) {
			return;
		}
		Vector3 destination = poi.transform.position;
		destination = Vector3.Lerp(transform.position, destination, easing);
		destination.z = camZ;

		transform.position = destination;
	
	}

}

