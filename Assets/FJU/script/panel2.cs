using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel2 : MonoBehaviour {


    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Escape)))
        {
            Debug.Log("Panel2 關閉");
            UIManager.checkopen = 0;
            UIManager.Instance.ClosePanel("Panel2");
        }
    }
}
