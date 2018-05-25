using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchOpenPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    if (hit.transform.name == "聖言樓(SF)")
                    {
                        Debug.Log("Panel聖言打開");
                        UIManager.Instance.ShowPanel("Panel聖言");
                    }
                    if (hit.transform.name == "文開樓(LE)")
                    {
                        Debug.Log("Panel文開打開");
                        UIManager.Instance.ShowPanel("Panel文開");
                    }
                    if (hit.transform.name == "耕莘樓(A)")
                    {
                        Debug.Log("Panel耕莘打開");
                        UIManager.Instance.ShowPanel("Panel耕莘");
                    }
                    if (hit.transform.name == "利瑪竇大樓(LM)")
                    {
                        Debug.Log("Panel利瑪竇打開");
                        UIManager.Instance.ShowPanel("Panel利瑪竇");
                    }
                    if (hit.transform.name == "進修部大樓(ES)")
                    {
                        Debug.Log("Panel進修部打開");
                        UIManager.Instance.ShowPanel("Panel進修部");
                    }
                    if (hit.transform.name == "樹德樓(LW)")
                    {
                        Debug.Log("Panel樹德打開");
                        UIManager.Instance.ShowPanel("Panel樹德");
                    }
                    if (hit.transform.name == "朝橒樓(TC)")
                    {
                        Debug.Log("Panel朝橒打開");
                        UIManager.Instance.ShowPanel("Panel朝橒");
                    }
                    if (hit.transform.name == "國璽樓(MD)")
                    {
                        Debug.Log("Panel國璽打開");
                        UIManager.Instance.ShowPanel("Panel國璽");
                    }
                    if (hit.transform.name == "外語學院(FG,AV,LA,LB)")
                    {
                        Debug.Log("Panel外語學院打開");
                        UIManager.Instance.ShowPanel("Panel外語學院");
                    }

                }




            }
        }
    }
}

