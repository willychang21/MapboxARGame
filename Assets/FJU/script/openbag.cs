using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openbag : MonoBehaviour {

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    public void disshow()
    {
        UIManager.Instance.ClosePanel("bagPanel");
        UIManager.checkopen = 0;


    }
    public void show()
    {
        Debug.Log("開背包" );
        if (UIManager.checkopen == 0) {
            UIManager.Instance.ShowPanel("bagPanel");
            UIManager.checkopen = 3;

        }
        else if (UIManager.checkopen == 3)
        {  
            UIManager.Instance.ClosePanel("bagPanel");
            UIManager.checkopen = 0;

        }
            
    }
}
