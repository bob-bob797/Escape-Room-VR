using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpen : MonoBehaviour {
	public bool locked;
	public GameObject lid;
	public GameObject key;

	void OnTriggerEnter(Collider collision) {
		Debug.Log (collision.gameObject.name);
		if (collision.gameObject == key) {
			lid.GetComponent<openLid> ().open ();
		}
	}
}
