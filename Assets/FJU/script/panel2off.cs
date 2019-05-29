using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel2off : MonoBehaviour {

    // Use this for initialization
    public void paneloff()
    {

        Debug.Log("Panel2關閉");
        UIManager.Instance.ClosePanel(UIManager.nowpanel);
        UIManager.checkopen = 0;
    }

    // Update is called once per frame
    void Update () {
        if (Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Escape)))
        {
            Debug.Log("Panel2關閉");
            UIManager.Instance.ClosePanel("Panel2");
            UIManager.checkopen = 0;
        }

    }
}
