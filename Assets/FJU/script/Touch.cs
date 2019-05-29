using Mapbox.Examples;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Touch : MonoBehaviour
{
    float checktimey = 0f;
    public static int checkstatus = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 40f))  //TODO:距離待實測
            {

                #region 觸擊判斷
                if (bar2move.LV >= 0)
                {
                    Debug.Log(hit.transform.name);
                    switch (hit.transform.name)
                    {
                        
                        #region 0等大樓
                        case "聖言樓(SF)":
                            Debug.Log("點聖言樓(SF)");
                            UIManager.a = 3;
                            UIManager.b = 4;
                            UIManager.c = 5;
                            if (UIManager.SFlock == 0 || UIManager.SFlock == 1)
                            {
                                UIManager.Instance.ShowPanel("Panel1");
                                UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                UIManager.nowpanelshowtext = "佔領聖言樓";
                                UIManager.SFlock = 1;
                            }
                            else if (UIManager.SFlock == 2)
                            {
                                UIManager.Instance.ShowPanel("PanelSF");
                                UIManager.nowpanel = "PanelSF";                   //判斷現在開啟哪個PANEL的變數
                            }

                            break;

                        case "朝橒樓(TC)":
                            Debug.Log("朝橒樓(TC)");
                            UIManager.a = 5;
                            UIManager.b = 4;
                            UIManager.c = 4;
                            if (UIManager.TClock == 0 || UIManager.TClock == 1)
                            {
                                UIManager.Instance.ShowPanel("Panel1");
                                UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                UIManager.nowpanelshowtext = "佔領朝橒樓";
                                UIManager.TClock = 1;
                            }
                            else if (UIManager.TClock == 2)
                            {
                                UIManager.Instance.ShowPanel("PanelTC");
                                UIManager.nowpanel = "PanelTC";                   //判斷現在開啟哪個PANEL的變數
                            }

                            break;



                        case "羅耀拉大樓(SL)":
                            Debug.Log("羅耀拉大樓(SL)");
                            UIManager.a = 3;
                            UIManager.b = 3;
                            UIManager.c = 5;
                            if (UIManager.SLlock == 0 || UIManager.SLlock == 1)
                            {
                                UIManager.Instance.ShowPanel("Panel1");
                                UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                UIManager.nowpanelshowtext = "佔領羅耀拉大樓";
                                UIManager.SLlock = 1;
                            }
                            else if (UIManager.SLlock == 2)
                            {
                                UIManager.Instance.ShowPanel("PanelSL");          // ******************待改 SL
                                UIManager.nowpanel = "PanelSL";                   //判斷現在開啟哪個PANEL的變數
                            }
                            break;




                        case "耕莘樓(A)":
                            Debug.Log("耕莘樓(A)");
                            UIManager.a = 4;
                            UIManager.b = 3;
                            UIManager.c = 3;
                            if (UIManager.Alock == 0 || UIManager.Alock == 1)
                            {
                                UIManager.Instance.ShowPanel("Panel1");
                                UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                UIManager.nowpanelshowtext = "佔領耕莘樓";
                                UIManager.Alock = 1;
                            }
                            else if (UIManager.Alock == 2)
                            {
                                UIManager.Instance.ShowPanel("PanelA");
                                UIManager.nowpanel = "PanelA";                   //判斷現在開啟哪個PANEL的變數
                            }
                            break;





                        case "進修部大樓(ES)":
                            Debug.Log("進修部大樓(ES)");
                            UIManager.a = 3;
                            UIManager.b = 5;
                            UIManager.c = 5;
                            if (UIManager.ESlock == 0 || UIManager.ESlock == 1)
                            {
                                UIManager.Instance.ShowPanel("Panel1");
                                UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                UIManager.nowpanelshowtext = "佔領進修部大樓";
                                UIManager.ESlock = 1;
                            }
                            else if (UIManager.ESlock == 2)
                            {
                                UIManager.Instance.ShowPanel("PanelES");
                                UIManager.nowpanel = "PanelES";                   //判斷現在開啟哪個PANEL的變數
                            }
                            break;




                        case "文華樓(LI)":
                            Debug.Log("文華樓(LI)");
                            UIManager.a = 3;
                            UIManager.b = 4;
                            UIManager.c = 3;
                            if (UIManager.LIlock == 0 || UIManager.LIlock == 1)
                            {
                                UIManager.Instance.ShowPanel("Panel1");
                                UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                UIManager.nowpanelshowtext = "佔領文華樓";
                                UIManager.LIlock = 1;
                            }
                            else if (UIManager.LIlock == 2)
                            {
                                UIManager.Instance.ShowPanel("PanelLI");
                                UIManager.nowpanel = "PanelLI";                   //判斷現在開啟哪個PANEL的變數
                            }
                            break;
                        #endregion

                        #region 學生餐廳

                        case "心園":
                            Debug.Log("心園");

                            UIManager.Instance.ShowPanel("Shin_restPanel");
                            UIManager.nowpanel = "Shin_restPanel";
                            break;

                        case "輔園":
                            Debug.Log("輔園");

                            UIManager.Instance.ShowPanel("Fu_restPanel");
                            UIManager.nowpanel = "Fu_restPanel";
                            break;

                        case "理園":
                            Debug.Log("理園");
                            UIManager.Instance.ShowPanel("Li_restPanel");
                            UIManager.nowpanel = "Li_restPanel";
                            break;

                        case "仁園":
                            Debug.Log("仁園");
                            UIManager.Instance.ShowPanel("Ren_restPanel");
                            UIManager.nowpanel = "Ren_restPanel";
                            break;

                        case "文園":
                            Debug.Log("文園");
                            UIManager.Instance.ShowPanel("Wen_restPanel");
                            UIManager.nowpanel = "Wen_restPanel";
                            break;
                        #endregion

                        #region 圖書館
                        case "國璽樓圖書館":
                            Debug.Log("國璽樓圖書館");

                            UIManager.Instance.ShowPanel("libraryPanel");
                            UIManager.nowpanel = "libraryPanel";
                            break;

                        case "濟時樓圖書館":
                            Debug.Log("濟時樓圖書館");

                            UIManager.Instance.ShowPanel("libraryPanel");
                            UIManager.nowpanel = "libraryPanel";
                            break;

                        case "公博樓圖書館":
                            Debug.Log("公博樓圖書館");

                            UIManager.Instance.ShowPanel("libraryPanel");
                            UIManager.nowpanel = "libraryPanel";
                            break;
                        #endregion

                        #region 地標景點
                        case "中美堂":
                            Debug.Log("中美堂");

                            UIManager.Instance.ShowPanel("landmarkPanel");
                            UIManager.nowpanel = "landmarkPanel";
                            break;

                        case "淨心堂":
                            Debug.Log("淨心堂");

                            UIManager.Instance.ShowPanel("landmarkPanel");
                            UIManager.nowpanel = "landmarkPanel";
                            break;

                        case "真善美聖":
                            Debug.Log("真善美聖");

                            UIManager.Instance.ShowPanel("landmarkPanel");
                            UIManager.nowpanel = "landmarkPanel";
                            break;

                        case "情人坡":
                            Debug.Log("情人坡");

                            UIManager.Instance.ShowPanel("landmarkPanel");
                            UIManager.nowpanel = "landmarkPanel";
                            break;

                        case "食科冰淇淋":
                            Debug.Log("食科冰淇淋");

                            UIManager.Instance.ShowPanel("landmarkPanel");
                            UIManager.nowpanel = "landmarkPanel";
                            break;
                        #endregion

                        #region 物件
                        case "Eraser(Clone)":

                            break;
                        case "Stapler black(Clone)":

                            break;
                        case "Calculator 1(Clone)":

                            break;
                        #endregion

                        #region Button
                        case "DeviceOrientation":     // 造成 一直顯示等級不足的東西

                            break;
                        #endregion

                        default:
                            //----------------------------------------10等
                            #region 10等大樓
                            if (bar2move.LV >= 10)
                            {
                                switch (hit.transform.name)
                                {

                                    case "利瑪竇大樓(LM)":
                                        Debug.Log("利瑪竇大樓(LM)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.LMlock == 0 || UIManager.LMlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領利瑪竇大樓";
                                            UIManager.LMlock = 1;
                                        }
                                        else if (UIManager.LMlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLM");
                                            UIManager.nowpanel = "PanelLM";                   //判斷現在開啟哪個PANEL的變數
                                        }

                                        break;

                                    case "文友樓(LF)":
                                        Debug.Log("文友樓(LF)");
                                        UIManager.a = 7;
                                        UIManager.b = 7;
                                        UIManager.c = 8;

                                        if (UIManager.LFlock == 0 || UIManager.LFlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領文友樓";
                                            UIManager.LFlock = 1;
                                        }
                                        else if (UIManager.LFlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLF");
                                            UIManager.nowpanel = "PanelLF";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;


                                    case "外語學院(FG,AV,LA,LB)":
                                        Debug.Log("外語學院(FG,AV,LA,LB)");
                                        UIManager.a = 9;
                                        UIManager.b = 5;
                                        UIManager.c = 6;

                                        if (UIManager.LAlock == 0 || UIManager.LAlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領外語學院";
                                            UIManager.LAlock = 1;
                                        }
                                        else if (UIManager.LAlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLA");
                                            UIManager.nowpanel = "PanelLA";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "野聲樓(YP)":
                                        Debug.Log("野聲樓(YP)");
                                        UIManager.a = 7;
                                        UIManager.b = 7;
                                        UIManager.c = 8;

                                        if (UIManager.YPlock == 0 || UIManager.YPlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領野聲樓";
                                            UIManager.YPlock = 1;
                                        }
                                        else if (UIManager.YPlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelYP");
                                            UIManager.nowpanel = "PanelYP";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "國璽樓(MD)":
                                        Debug.Log("國璽樓(MD)");
                                        UIManager.a = 7;
                                        UIManager.b = 7;
                                        UIManager.c = 8;

                                        if (UIManager.MDlock == 0 || UIManager.MDlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領國璽樓";
                                            UIManager.MDlock = 1;
                                        }
                                        else if (UIManager.MDlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelMD");
                                            UIManager.nowpanel = "PanelMD";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "文開樓(LE)":
                                        Debug.Log("文開樓(LE)");
                                        UIManager.a = 7;
                                        UIManager.b = 7;
                                        UIManager.c = 8;

                                        if (UIManager.LElock == 0 || UIManager.LElock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領文開樓";
                                            UIManager.LElock = 1;
                                        }
                                        else if (UIManager.LElock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLE");
                                            UIManager.nowpanel = "PanelLE";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "伯達樓(BS)":
                                        Debug.Log("伯達樓(BS)");
                                        UIManager.a = 7;
                                        UIManager.b = 7;
                                        UIManager.c = 8;

                                        if (UIManager.BSlock == 0 || UIManager.BSlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領伯達樓";
                                            UIManager.BSlock = 1;
                                        }
                                        else if (UIManager.BSlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelBS");
                                            UIManager.nowpanel = "PanelBS";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;



                                    default:
                                        if (bar2move.LV < 20)
                                        {
                                            Debug.Log("等級未到無法佔領20等以上建築物");
                                            UIManager.Instance.ShowPanel("LevelInsufficient-Panel");
                                            checkstatus = 1;
                                        }
                                        break;


                                }
                            }
                            #endregion
                            //----------------------------------------20等
                            #region 20等大樓
                            else if (bar2move.LV >= 20)
                            {
                                switch (hit.transform.name)
                                {

                                    case "倬章樓(DG)":
                                        Debug.Log("倬章樓(DG)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.DGlock == 0 || UIManager.DGlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領倬傽樓";
                                            UIManager.DGlock = 1;
                                        }
                                        else if (UIManager.DGlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelDG");
                                            UIManager.nowpanel = "PanelDG";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "積健樓(LP)":
                                        Debug.Log("積健樓(LP)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.LPlock == 0 || UIManager.LPlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領積健樓";
                                            UIManager.LPlock = 1;
                                        }
                                        else if (UIManager.LPlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLP");
                                            UIManager.nowpanel = "PanelLP";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "理工綜合教室(LH)":
                                        Debug.Log("理工綜合教室(LH)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.LHlock == 0 || UIManager.LHlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領理工綜合教室";
                                            UIManager.LHlock = 1;
                                        }
                                        else if (UIManager.LHlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLH");
                                            UIManager.nowpanel = "PanelLH";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "藝術學院(AG)":
                                        Debug.Log("藝術學院(AG)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.AGlock == 0 || UIManager.AGlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領藝術學院";
                                            UIManager.AGlock = 1;
                                        }
                                        else if (UIManager.AGlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelAG");
                                            UIManager.nowpanel = "PanelAG";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "秉雅樓(NF)":
                                        Debug.Log("秉雅樓(NF)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.NFlock == 0 || UIManager.NFlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領秉雅樓";
                                            UIManager.NFlock = 1;
                                        }
                                        else if (UIManager.NFlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelNF");
                                            UIManager.nowpanel = "PanelNF";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                    case "樹德樓(LW)":
                                        Debug.Log("樹德樓(LW)");
                                        UIManager.a = 6;
                                        UIManager.b = 8;
                                        UIManager.c = 7;

                                        if (UIManager.LWlock == 0 || UIManager.LWlock == 1)
                                        {
                                            UIManager.Instance.ShowPanel("Panel1");
                                            UIManager.nowpanel = "Panel1";                    //判斷現在開啟哪個PANEL的變數
                                            UIManager.nowpanelshowtext = "佔領樹德樓";
                                            UIManager.LWlock = 1;
                                        }
                                        else if (UIManager.LWlock == 2)
                                        {
                                            UIManager.Instance.ShowPanel("PanelLW");
                                            UIManager.nowpanel = "PanelLW";                   //判斷現在開啟哪個PANEL的變數
                                        }
                                        break;

                                }
                            }
                            #endregion
                            else                                                               //  LV<10 顯示
                            {
                                Debug.Log("等級未到無法佔領10等以上建築物");
                                UIManager.Instance.ShowPanel("LevelInsufficient-Panel");
                                checkstatus = 1;

                            }

                            break;
                    }
                }
                #endregion

            }
        }
        if (checkstatus >= 1)                                               //LevelInsufficient-Panel自動關閉偵測
        {
            checktimey += Time.deltaTime;
            if (checktimey >= 1.5)
            {
                UIManager.Instance.ClosePanel("LevelInsufficient-Panel");
                checktimey = 0f;
                checkstatus = 0;

            }
        }
        else
        {
            checktimey = 0f;
        }
    }

}
