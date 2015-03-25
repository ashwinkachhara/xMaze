using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// This script displays the "Winner!!!" dialog when player is in the vicinity of the treasure chest.
public class WinScript : MonoBehaviour {

	GameObject player, chest;
	public GameObject text;

	// 
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
