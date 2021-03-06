﻿using UnityEngine;
using System.Collections;

public class MultiBeamScript : MonoBehaviour {

	GameObject newBeamL, newBeamR;
	float i;

	// Spawn multiple linerenderers to make the cyclops beam.
	void Start () {
		for (i = (float)0.5; i>0; i-=(float)0.02) {
			//Debug.Log (i);
			newBeamL = new GameObject();
			newBeamL.transform.parent = transform;
			newBeamL.AddComponent<LineRenderer>();
			newBeamL.AddComponent<CyclopsScript>();
			newBeamL.transform.localPosition = new Vector3(-i, 0, (float)0.5);
			newBeamL.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
			newBeamL.tag = "Player";

			newBeamR = new GameObject();
			newBeamR.transform.parent = transform;
			newBeamR.AddComponent<LineRenderer>();
			newBeamR.AddComponent<CyclopsScript>();
			newBeamR.transform.localPosition = new Vector3(i, 0, (float)0.5);
			newBeamR.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
			newBeamR.tag = "Player";
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
