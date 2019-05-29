using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landmark : MonoBehaviour {

    static public int isShow = 0;
    int originalDay = 0;

    void Start()
    {
        originalDay = PlayerPrefs.GetInt("Day");
    }

    public void showitem()
    {
        var date = System.DateTime.Now;
        var useday = date.Day.ToString();
        int day = int.Parse(useday);
        if (originalDay != day)
        {
            PlayerPrefs.SetInt("Day", day);
            isShow = 1;
        }
    }

}
