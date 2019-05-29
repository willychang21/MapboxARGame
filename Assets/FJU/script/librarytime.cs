using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class librarytime : MonoBehaviour {

    int timeint = 300;
    public Text timetext;
    float checktime = 0;
    int checkstatus = 0;
    public static int nn1=0, nn2=0, nn3=0;

    public void OnBtnClick()
    {
        
        if (UIManager.librarycheckstatus== true)
        {
            InvokeRepeating("timer", 1, 1);
            UIManager.librarycheckstatus = false;
            UIManager.librarytargettime = System.DateTime.Now.AddHours(2);

        }
        else                                    
        {
            UIManager.Instance.ShowPanel("CoolingTime-Panel");
            checkstatus = 1;

        }
    }

    void Update()
    {
        if (checkstatus >= 1)
        {
            checktime+=Time.deltaTime;
            if (checktime >=1.5)
            {
                UIManager.Instance.ClosePanel("CoolingTime-Panel");
                checktime = 0;
                checkstatus = 0;
            }
        }
        else
        {
            checktime = 0f;
        }
    }

   void timer()
    {
        timeint -= 1;
        timetext.text = timeint + "";

        if (timeint == 0)
        {
            nn1 = Random.Range(0, 4);
            bar2move.n1 = bar2move.n1 + nn1;
            
            PlayerPrefs.SetInt("n1", bar2move.n1);
            nn2 = Random.Range(0, 4);
            bar2move.n2 = bar2move.n2 + nn2;
            PlayerPrefs.SetInt("n2", bar2move.n2);
            nn3 = Random.Range(0, 4);
            bar2move.n3 = bar2move.n3 + nn3;
            PlayerPrefs.SetInt("n3", bar2move.n3);

            timetext.text = "BONUS !";
            timeint = 10;
            CancelInvoke("timer");
            UIManager.librarytxtcheckstatus = true;
        }
    }
}
