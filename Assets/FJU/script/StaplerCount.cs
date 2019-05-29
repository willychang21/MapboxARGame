using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaplerCount : MonoBehaviour {

    private int n3;
    public Text a;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        n3 = bar2move.n3;
        a.text = n3 + "";
    }
}
