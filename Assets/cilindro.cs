using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindro : MonoBehaviour {
	private bool cado = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (cado) {
			float yRotation = transform.eulerAngles.z;
			if (yRotation > 45) {
				palla.coll++;
				cado = false;
			}

		}
	}
}
