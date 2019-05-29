using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangetheScene : MonoBehaviour {

    public void BtnClick()
    {
        SceneManager.LoadScene("WorldScaleAR");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
