using UnityEngine;
using System.Collections.Generic;

public class UIManager : Singleton<UIManager>
{
    private string UI_GAMEPANEL_ROOT = "Prefabs/GamePanel/";

    public GameObject m_CanvasRoot;

    public Dictionary<string, GameObject> m_PanelList = new Dictionary<string, GameObject>();

    static public bool checkopen = true;

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
        if (checkopen == true)
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

            checkopen = false;
            return panel;
            
        }
        else
        {
            Debug.LogErrorFormat("Only can open one panel");
            return null;
        }
            


            
        
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
