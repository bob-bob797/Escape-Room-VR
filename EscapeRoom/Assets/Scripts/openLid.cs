using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLid : MonoBehaviour {
	public bool opened;
	public float smooth;
	public float rotationTime;
	public Vector3 finalRotation;
	public GameObject rotatePoint;

	private float endTime;

	public void open() {
		opened = true;

		endTime = Time.time + rotationTime;
	}

	void Update () {
		if (opened && Time.time < endTime) {
			transform.RotateAround (rotatePoint.transform.position, finalRotation, Time.deltaTime * smooth);
		}
	}
}
