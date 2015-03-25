using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {

	//Text win;
	GameObject player, chest;
	Transform canvas;
	public GameObject text;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Cyclops");
		chest = this.gameObject;
		//win = GetComponent<Text> ();
		text.SetActive (false);
		//win.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		double dist = Vector3.Distance (chest.transform.position, player.transform.position);
		//Debug.Log (dist);
		if (dist < 7)
			text.SetActive (true);
			//win.enabled = true;
	}

}
