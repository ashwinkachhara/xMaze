using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public GameObject DestroyedObject;
	public bool destruct;

	void Start(){
		destruct = false;
	}

	void Update(){
		if (destruct) {
			DestroyIt();
		}
	}
	
	void OnCollisionEnter( Collision collision) {
		//if (collision.contacts){

	}
	
		void DestroyIt(){
		if(DestroyedObject) {
			Instantiate(DestroyedObject, transform.position, transform.rotation);
		}
		Destroy(gameObject);

	}
}