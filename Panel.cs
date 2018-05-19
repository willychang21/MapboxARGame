using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour {

    public void OnBtnShowClick()
    {
        Debug.Log("Panel關閉");
        UIManager.checkopen = true;
        UIManager.Instance.ClosePanel("Panel");
    }
}
