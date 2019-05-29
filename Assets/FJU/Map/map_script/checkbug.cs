using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkbug : MonoBehaviour {

    [SerializeField]
    Text _Test;

    [SerializeField]
    Transform _MapCam;

    [SerializeField]
    Transform _AbstractMap;



	// Update is called once per frame
	void Update () {
        _Test.text = "MapCam's position : " + _MapCam.position + "\n"
                   + "MapCam's rotation : " + _MapCam.rotation + "\n"
                   + "AbstractMap's position : " + _AbstractMap.position + "\n"
                   + "AbstractMap's rotation : " + _AbstractMap.rotation + "\n";
	}
}
