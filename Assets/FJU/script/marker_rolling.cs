using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marker_rolling : MonoBehaviour {
	public bool a=true;
	int b=0;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 50) * Time.deltaTime);

		if (a == true) {
			transform.Translate (Vector3.up* Time.deltaTime*4, Space.World);
			b++;
		} 
		else if(a==false ) {
			transform.Translate (Vector3.down* Time.deltaTime*4, Space.World);
			b--;
		}
		if(b>90)
			a=false;
		else if(b<0)
			a=true;
	}

}
