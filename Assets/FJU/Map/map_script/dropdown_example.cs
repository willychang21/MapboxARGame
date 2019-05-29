using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown_example : MonoBehaviour
{



    [SerializeField]
    Camera _camera;

    [SerializeField]
    Image marker;


    Dropdown m_Dropdown;
    string m_Message;
    int m_DropdownValue;

    string des_object_name; //選擇的物件名字
    GameObject des_object;  //選擇的物件

    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();

        Debug.Log("Starting Dropdown Value : " + m_Dropdown.value);


    }

    void Update()
    {

        m_DropdownValue = m_Dropdown.value;

        m_Message = m_Dropdown.options[m_DropdownValue].text;

       

        if (m_Message != "尚未選擇")
        {
            Debug.Log("dropdown_example : 選擇 " + m_Message);
            if (des_object_name != m_Message)
            {
                Debug.Log("des_object_name != m_Message ,need to Create new image");
                des_object_name = m_Message;
                des_object = GameObject.Find(des_object_name);
                PoiMarkerHelper.localpos = des_object.GetComponent<Transform>().position;
                if (PoiMarkerHelper.markcheck)    //偵測是否已有Marker存在，沒有才可以進來create
                {
                    time_dis._dnameforglobal = des_object_name;
                    Instantiate(marker, _camera.WorldToScreenPoint(des_object.GetComponent<Transform>().position), new Quaternion(0, 0, 0, 0));
                    Instantiate(Resources.Load("Directions") as GameObject);
                    Instantiate(Resources.Load("PredictPanel") as GameObject);
                    PoiMarkerHelper.markcheck = false;
                }
            }
            else
            {
                Debug.Log("des_object_name = m_Message ,don't Create new image");
            }
        }
        else
        {
            Debug.Log("dropdown_example : You have'nt choosen yet.");
        }

    

    }


}