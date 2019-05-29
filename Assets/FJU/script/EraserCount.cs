using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EraserCount : MonoBehaviour
{

    private int n1;
    public Text a;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        n1 = bar2move.n1;
        a.text = n1 + "";
    }
}