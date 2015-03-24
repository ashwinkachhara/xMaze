using UnityEngine;
using System.Collections;

public class CyclopsScript : MonoBehaviour {

	LineRenderer line;

	// Use this for initialization
	void Start () {
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = false;
		line.material = new Material (Shader.Find ("Particles/Additive"));
		line.SetColors (Color.red, Color.red);
		line.SetWidth ((float)0.15, (float)0.15);

		//Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("left ctrl")) {
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");
		}
	}

	IEnumerator FireLaser(){
		line.enabled = true;

		while (Input.GetKey("left ctrl")) {
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;

			line.SetPosition(0, ray.origin);

			if (Physics.Raycast(ray, out hit, 100)){
				line.SetPosition(1, hit.point);
				if (hit.rigidbody){
					//hit.rigidbody.AddForceAtPosition(transform.forward*5, hit.point);
					GameObject collidee = hit.rigidbody.gameObject;
					if (collidee.tag == "DestWall"){
						Hit s = collidee.GetComponent<Hit>();
						s.destruct = true;
					}
				}
			}
			else
				line.SetPosition(1, ray.GetPoint(100));

			yield return null;
		}

		line.enabled = false;
	}
}
