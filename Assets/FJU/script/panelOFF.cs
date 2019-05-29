using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelOFF : MonoBehaviour
{


    public void paneloff()
    {

        Debug.Log(UIManager.nowpanel + "關閉");
        UIManager.Instance.ClosePanel(UIManager.nowpanel);
        UIManager.checkopen = 0;
        UIManager.nowpanel = "";  
        UIManager.nowpanelshowtext = "";

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
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Escape)))
        {
            Debug.Log("Panel關閉");
            UIManager.checkopen = 0;
            UIManager.Instance.ClosePanel("Panel1");
            UIManager.nowpanelshowtext = "";
            #region 大樓LOCK歸零
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
    }
}
