using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public Text objtext1;
    public Text objtext2;
    public Text objtext3;
    public Text objtext4;
    float checktime = 0f;
    int checkstatus = 0;

    public void OnBtnShowClick()
    {


        Debug.Log("a:" + UIManager.a + " b:" + UIManager.b + " c:" + UIManager.c);
        if (bar2move.n1 >= UIManager.a && bar2move.n2 >= UIManager.b && bar2move.n3 >= UIManager.c)
        {
            Debug.Log("Panel1111關閉");
            UIManager.Instance.ClosePanel("Panel1");


            bar2move.n1 = bar2move.n1 - UIManager.a;
            bar2move.n2 = bar2move.n2 - UIManager.b;
            bar2move.n3 = bar2move.n3 - UIManager.c;
            #region 開啟大樓Panel
            if (UIManager.SFlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelSF");
                UIManager.nowpanel = "PanelSF";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.SFlock = 2;
                bar2move.num += 5;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.TClock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelTC");
                UIManager.nowpanel = "PanelTC";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.TClock = 2;
                bar2move.num += 2;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.SLlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelSL");
                UIManager.nowpanel = "PanelSL";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.SLlock = 2;
                bar2move.num += 2;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.Alock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelA");
                UIManager.nowpanel = "PanelA";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.Alock = 2;
                bar2move.num += 4;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.ESlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelES");
                UIManager.nowpanel = "PanelES";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.ESlock = 2;
                bar2move.num += 2;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LIlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLI");
                UIManager.nowpanel = "PanelLI";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LIlock = 2;
                bar2move.num += 3;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LMlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLM");
                UIManager.nowpanel = "PanelLM";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LMlock = 2;
                bar2move.num += 4;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LFlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLF");
                UIManager.nowpanel = "PanelLF";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LFlock = 2;
                bar2move.num += 2;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.YPlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelYP");
                UIManager.nowpanel = "PanelYP";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.YPlock = 2;
                bar2move.num += 6;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LAlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLA");
                UIManager.nowpanel = "PanelLA";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LAlock = 2;
                bar2move.num += 7;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.MDlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelMD");
                UIManager.nowpanel = "PanelMD";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.MDlock = 2;
                bar2move.num += 5;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LElock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLE");
                UIManager.nowpanel = "PanelLE";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LElock = 2;
                bar2move.num += 9;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.BSlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelBS");
                UIManager.nowpanel = "PanelBS";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.BSlock = 2;
                bar2move.num += 5;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.DGlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelDG");
                UIManager.nowpanel = "PanelDG";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.DGlock = 2;
                bar2move.num += 15;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LPlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLP");
                UIManager.nowpanel = "PanelLP";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LPlock = 2;
                bar2move.num += 16;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LHlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLH");
                UIManager.nowpanel = "PanelLH";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LHlock = 2;
                bar2move.num += 15;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.AGlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelAG");
                UIManager.nowpanel = "PanelAG";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.AGlock = 2;
                bar2move.num += 15;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.NFlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelNF");
                UIManager.nowpanel = "PanelNF";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.NFlock = 2;
                bar2move.num += 20;                                                       //佔領大樓的獎勵
            }
            else if (UIManager.LWlock == 1)
            {
                UIManager.checkopen = 2;
                UIManager.Instance.ShowPanel("PanelLW");
                UIManager.nowpanel = "PanelLW";                                          //判斷現在開啟哪個PANEL的變數
                UIManager.LWlock = 2;
                bar2move.num += 24;                                                       //佔領大樓的獎勵
            }
            #endregion
        }
        else
        {
            Debug.Log("物件不夠 無法開啟" + UIManager.nowpanel);
            UIManager.Instance.ShowPanel("Insufficient-Panel");
            checkstatus = 1;
        }
    }

    void Update()
    {
        objtext1.text = UIManager.a + "";
        objtext2.text = UIManager.b + "";
        objtext3.text = UIManager.c + "";
        objtext4.text = UIManager.nowpanelshowtext;

        if (Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Escape)))
        {
            Debug.Log("Panel關閉");
            UIManager.checkopen = 0;
            UIManager.Instance.ClosePanel("Panel1");
            UIManager.nowpanelshowtext = "";
            objtext4.text = UIManager.nowpanelshowtext;
            #region 未佔領的大樓LOCK歸零
            if (UIManager.SFlock == 1)
            {
                UIManager.SFlock = 0;
            }
            else if (UIManager.TClock == 1)
            {
                UIManager.TClock = 0;
            }
            else if (UIManager.SLlock == 1)
            {
                UIManager.SLlock = 0;
            }
            else if (UIManager.Alock == 1)
            {
                UIManager.Alock = 0;
            }
            else if (UIManager.ESlock == 1)
            {
                UIManager.ESlock = 0;
            }
            else if (UIManager.LIlock == 1)
            {
                UIManager.LIlock = 0;
            }

            else if (UIManager.LMlock == 1)
            {
                UIManager.LMlock = 0;
            }
            else if (UIManager.LFlock == 1)
            {
                UIManager.LFlock = 0;
            }
            else if (UIManager.YPlock == 1)
            {
                UIManager.YPlock = 0;
            }
            else if (UIManager.LAlock == 1)
            {
                UIManager.LAlock = 0;
            }
            else if (UIManager.MDlock == 1)
            {
                UIManager.MDlock = 0;
            }


            else if (UIManager.LElock == 1)
            {
                UIManager.LElock = 0;
            }
            else if (UIManager.BSlock == 1)
            {
                UIManager.BSlock = 0;
            }
            else if (UIManager.DGlock == 1)
            {
                UIManager.DGlock = 0;
            }
            else if (UIManager.LPlock == 1)
            {
                UIManager.LPlock = 0;
            }
            else if (UIManager.LHlock == 1)
            {
                UIManager.LHlock = 0;
            }


            else if (UIManager.AGlock == 1)
            {
                UIManager.AGlock = 0;
            }
            else if (UIManager.NFlock == 1)
            {
                UIManager.NFlock = 0;
            }
            else if (UIManager.LWlock == 1)
            {
                UIManager.LWlock = 0;
            }
            #endregion
        }

        if (checkstatus >= 1)
        {
            checktime+=Time.deltaTime;
            if (checktime >=1.5)
            {
                UIManager.Instance.ClosePanel("Insufficient-Panel");
                checktime = 0;
                checkstatus = 0;
            }
            else
            {
                checktime = 0f;
            }
        }
    }
}