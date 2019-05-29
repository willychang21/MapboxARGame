using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorCount : MonoBehaviour {

    private int n2;
    public Text a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        n2 = bar2move.n2;
        a.text = n2 + "";
	}
}
