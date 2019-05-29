using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _markeractive: MonoBehaviour {

    // Use this for initialization
    static public Transform tran;

    void Awake () {

        tran = gameObject.transform;

        if(Camera.main.isActiveAndEnabled)
        {
            gameObject.SetActive(false);
        }

    }

}
