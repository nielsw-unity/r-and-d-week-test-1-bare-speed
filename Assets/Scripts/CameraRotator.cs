using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour {

	public GameObject spawner;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		var origin = spawner.transform.position;
		transform.LookAt(origin);
		transform.RotateAround(origin, new Vector3(0.0f, 1.0f, 0.0f), 20.0f * Time.deltaTime);
	}
}



