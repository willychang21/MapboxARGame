using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeText : MonoBehaviour {

    public Text tt = null;
    int num = 0;

    public void changeRight(string word1)
    {
        if (num == 0)
        {
            tt.text = word1;
            num = 1;
        }

    }

    public void changeLeft(string word2)
    {
        if(num == 1)
        {
            tt.text = word2;
            num = 0;
        }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
