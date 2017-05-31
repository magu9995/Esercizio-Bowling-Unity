using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ui_buttons : MonoBehaviour {

	public static bool impulse = true;
	private int force = 4;
	Text text;
	public palla script;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = ""+palla.coll;
	}

	public void muovi_destra(){
		GameObject palla = GameObject.Find ("palla");
		palla.transform.Translate (0,0,Time.deltaTime*4);
	}
	public void muovi_sinistra(){
		GameObject palla = GameObject.Find ("palla");
		palla.transform.Translate (0,0, -Time.deltaTime*4);
	}

	public void vai(){
		GameObject palla = GameObject.Find ("palla");

		if (impulse) {
			Rigidbody palla_rigid = palla.GetComponent<Rigidbody> ();
			//palla_rigid.AddForce (-force, force*1.5f, 0, ForceMode.Impulse);
			palla_rigid.AddForce (-force, 0, 0, ForceMode.Impulse);
			impulse=false;
		}
	}
		
}
