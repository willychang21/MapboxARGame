
using Mapbox.Examples;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchdis文開 : MonoBehaviour 
{



    

    void Update()
        {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
               
                if (hit.transform != null)
                {
                       
                        

                        Debug.Log("Panel");
                        UIManager.Instance.ShowPanel("Panel");
                    
                }
                
                


            }
        }
        
        
    }
}
