using UnityEngine;
using System.Collections.Generic;

public class UIManager : Singleton<UIManager>
{
    private string UI_GAMEPANEL_ROOT = "Prefabs/GamePanel/";

    public GameObject m_CanvasRoot;

    public Dictionary<string, GameObject> m_PanelList = new Dictionary<string, GameObject>();

    static public int checkopen = 0;     //  0:Panel都未開啟  1:Panel 1 開啟  2: Panel 2 開啟 3: 背包Panel 開啟
    static public int a = 1000, b = 1000, c = 1000;                   //佔領大樓需要物件數量
    static public string nowpanel = "";                               //判斷現在開啟哪個PANEL的變數
    static public string nowpanelshowtext = "";                       //顯示現在panel1開啟哪個大樓
    static public int PickupNumber = 0;                               //現在撿取數量
    static public string tmpdate ;                                    //時間暫存變數(為了判斷是否到了隔日)
    static public System.DateTime librarytargettime ;                 //確認圖書館目標時間  
    static public bool librarycheckstatus=true;                       //確認圖書館點擊狀態  true:可使用
    static public float ts_float;                                     //確認圖書館冷卻時間
    static public System.TimeSpan ts;                                 //圖書館冷卻時間
    static public bool resttxtcheckstatus = false;                    //確認餐廳交換物品顯示提示狀態
    static public bool librarytxtcheckstatus = false;                 //確認圖書館BOUNS顯示提示狀態
    #region 大樓panel變數
    static public int SFlock = 0;                                  // SF 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int TClock = 0;                                  // TC 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int SLlock = 0;                                  // SL 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int Alock = 0;                                   // A 是否解鎖       0:未解鎖 1:待解鎖 2:已解鎖
    static public int ESlock = 0;                                  // ES 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LIlock = 0;                                  // LI 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    //-----------  10等大樓
    static public int LMlock = 0;                                  // LM 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LFlock = 0;                                  // LF 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int YPlock = 0;                                  // YP 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LAlock = 0;                                  // LA 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int MDlock = 0;                                  // MD 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LElock = 0;                                  // LE 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int BSlock = 0;                                  // BS 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖

    //-----------  20等大樓
    static public int DGlock = 0;                                  // DG 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LPlock = 0;                                  // LP 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LHlock = 0;                                  // LH 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int AGlock = 0;                                  // AG 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int NFlock = 0;                                  // NF 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    static public int LWlock = 0;                                  // LW 是否解鎖      0:未解鎖 1:待解鎖 2:已解鎖
    #endregion

    private bool CheckCanvasRootIsNull()
    {
        if (m_CanvasRoot == null)
        {
            Debug.LogError("m_CanvasRoot is Null, Please in your Canvas add UIRootHandler.cs");
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool IsPanelLive(string name)
    {
        return m_PanelList.ContainsKey(name);
    }

    public GameObject ShowPanel(string name)
    {

        if (CheckCanvasRootIsNull())
            return null;

        if (IsPanelLive(name))
        {
            Debug.LogErrorFormat("[{0}] is Showing, if you want to show, please close first!!", name);
            return null;
        }

        GameObject loadGo = Utility.AssetRelate.ResourcesLoadCheckNull<GameObject>(UI_GAMEPANEL_ROOT + name);
        if (loadGo == null)
            return null;
        GameObject panel = Utility.GameObjectRelate.InstantiateGameObject(m_CanvasRoot, loadGo);
        panel.name = name;


        m_PanelList.Add(name, panel);

        checkopen = 1;
        return panel;

    }

    public void TogglePanel(string name, bool isOn)
    {
        if (IsPanelLive(name))
        {
            if (m_PanelList[name] != null)
                m_PanelList[name].SetActive(isOn);
        }
        else
        {
            Debug.LogErrorFormat("TogglePanel [{0}] not found.", name);
        }
    }

    public void ClosePanel(string name)
    {
        if (IsPanelLive(name))
        {
            if (m_PanelList[name] != null)
                Object.Destroy(m_PanelList[name]);

            m_PanelList.Remove(name);
        }
        else
        {
            Debug.LogErrorFormat("ClosePanel [{0}] not found.", name);
        }
    }

    public void CloseAllPanel()
    {
        foreach (KeyValuePair<string, GameObject> item in m_PanelList)
        {
            if (item.Value != null)
                Object.Destroy(item.Value);
        }

        m_PanelList.Clear();
    }

    public Vector2 GetCanvasSize()
    {
        if (CheckCanvasRootIsNull())
            return Vector2.one * -1;

        RectTransform trans = m_CanvasRoot.transform as RectTransform;

        return trans.sizeDelta;
    }

}