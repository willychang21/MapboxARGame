using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolingTime : MonoBehaviour {

    public Text text;

	// 冷卻PANEL
	void Start () {
        int ts_int = (int)UIManager.ts_float;
        int hour = (int)(ts_int / 3600);
        int min = (int)((ts_int - (hour * 3600))/60);
        int sec = (int)ts_int % 60;
        text.text= hour+":"+min+":"+sec;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
