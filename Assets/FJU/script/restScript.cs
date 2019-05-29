using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restScript : MonoBehaviour {

    int checkstatus = 0;
    float checktime = 0f;
    public Text text;
    public static string addimg="", subimg="", addtxt="", subtxt="";
    #region 學生餐廳點擊觸發兌換物品
    #region 心園
    public void Shin_BtnClick()
    {
        if (bar2move.n2 >= 2)
        {
            bar2move.n2 = bar2move.n2 - 2;
            bar2move.n1 = bar2move.n1 + 1;
            PlayerPrefs.SetInt("n2", bar2move.n2);
            PlayerPrefs.SetInt("n1", bar2move.n1);
            addimg="未命名-6";
            addtxt="+ 1";
            subimg="未命名";
            subtxt= "- 2";
            UIManager.resttxtcheckstatus = true;

        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }

    public void Shin_BtnClick2()
    {
        if (bar2move.n1 >= 2)
        {
            bar2move.n1 = bar2move.n1 - 2;
            bar2move.num = bar2move.num + 10;
            PlayerPrefs.SetInt("n1", bar2move.n1);
            PlayerPrefs.SetInt("num", bar2move.num);


            addimg = "未命名";    
            addtxt = "EXP+ 10";
            subimg = "123";
            subtxt = "- 2";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }
    #endregion
    #region 輔園
    public void Fu_BtnClick()
    {
        if (bar2move.n3 >= 2)
        {
            bar2move.n3 = bar2move.n3 - 2;
            bar2move.n1 = bar2move.n1 + 1;
            PlayerPrefs.SetInt("n3", bar2move.n3);
            PlayerPrefs.SetInt("n1", bar2move.n1);

            addimg = "未命名-4";
            addtxt = "+ 1";
            subimg = "未命名";
            subtxt = "- 2";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }

    public void Fu_BtnClick2()
    {
        if (bar2move.n3 >= 2)
        {
            bar2move.n3 = bar2move.n3 - 2;
            bar2move.n2 = bar2move.n2 + 1;
            PlayerPrefs.SetInt("n3", bar2move.n3);
            PlayerPrefs.SetInt("n2", bar2move.n2);
            addimg = "未命名-4";
            addtxt = "+ 1";
            subimg = "未命名-6";
            subtxt = "- 2";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }
    #endregion
    #region 仁園
    public void Ren_BtnClick()
    {
        if (bar2move.n1 >= 3)
        {
            bar2move.n1 = bar2move.n1 - 3;
            bar2move.n3 = bar2move.n3 + 2;
            PlayerPrefs.SetInt("n1", bar2move.n1);
            PlayerPrefs.SetInt("n3", bar2move.n3);

            addimg = "未命名";
            addtxt = "+ 2";
            subimg = "未命名-4";
            subtxt = "- 3";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }

    public void Ren_BtnClick2()
    {
        if (bar2move.n2 >= 3)
        {
            bar2move.n2 = bar2move.n2 - 3;
            bar2move.n1 = bar2move.n1 + 2;
            PlayerPrefs.SetInt("n2", bar2move.n2);
            PlayerPrefs.SetInt("n1", bar2move.n1);

            addimg = "未命名-6";
            addtxt = "+ 2";
            subimg = "未命名";
            subtxt = "- 3";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }
    #endregion
    #region 理園
    public void Li_BtnClick()
    {
        if (bar2move.n3 >= 2)
        {
            bar2move.n3 = bar2move.n3 - 2;
            bar2move.num = bar2move.num + 10;
            PlayerPrefs.SetInt("n3", bar2move.n3);
            PlayerPrefs.SetInt("num", bar2move.num);

            addimg = "未命名";     
            addtxt = "EXP+ 10";
            subimg = "123";
            subtxt = "- 2";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }

    public void Li_BtnClick2()
    {
        if (bar2move.n2 >= 4)
        {
            bar2move.n2 = bar2move.n2 - 4;
            bar2move.n3 = bar2move.n3 + 3;
            PlayerPrefs.SetInt("n3", bar2move.n3);
            PlayerPrefs.SetInt("n2", bar2move.n2);

            addimg = "未命名-6";
            addtxt = "+ 3";
            subimg = "未命名-4";
            subtxt = "- 4";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }
    #endregion
    #region 文園
    public void Wen_BtnClick()
    {
        if (bar2move.n1 >= 3)
        {
            bar2move.n1 = bar2move.n1 - 3;
            bar2move.n3 = bar2move.n3 + 2;
            PlayerPrefs.SetInt("n3", bar2move.n3);
            PlayerPrefs.SetInt("n1", bar2move.n1);

            addimg = "未命名";
            addtxt = "+ 2";
            subimg = "未命名-4";
            subtxt = "- 3";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }

    public void Wen_BtnClick2()
    {
        if (bar2move.n3 >= 4)
        {
            bar2move.n3 = bar2move.n3 - 4;
            bar2move.n2 = bar2move.n2 + 3;
            PlayerPrefs.SetInt("n3", bar2move.n3);
            PlayerPrefs.SetInt("n2", bar2move.n2);
            addimg="未命名-4";
            addtxt= "+ 3";
            subimg= "未命名-6";
            subtxt= "- 4";
            UIManager.resttxtcheckstatus = true;
        }
        else
        {
            text.text = "無法交換";
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }
    #endregion
    #endregion
    

        /// <summary>
        ///  Insufficient-Panel自動關閉偵測&& 提示通知
        /// </summary>
        void Update()
    {
        if (checkstatus >= 1)
        {
            checktime+=Time.deltaTime; 
            if (checktime>=1.5)
            {
                UIManager.Instance.ClosePanel("Insufficient-Panel");
                checktime = 0;
                checkstatus = 0;
                text.text = "無法佔領";
            }
            else
            {
                checktime = 0f;
            }
        }

    }

}
