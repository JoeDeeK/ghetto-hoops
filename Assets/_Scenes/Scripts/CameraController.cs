using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour { //created script instead making cam child of player because cam goes all over, x y z, we only wan it to follow on xz so create script
	

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {//whats late update?
		transform.position = player.transform.position + offset;
	}
}
