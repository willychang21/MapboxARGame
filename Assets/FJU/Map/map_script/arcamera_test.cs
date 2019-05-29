
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcamera_test : MonoBehaviour {

    [SerializeField]
    private bool test_camera;
	// Update is called once per frame
	void Update () {
        if(test_camera == true)
        {
            gameObject.transform.position = new Vector3(ImmediatePositionWithLocationProvider.user_localpos.x,5, ImmediatePositionWithLocationProvider.user_localpos.z);
        }
		
	}
}
