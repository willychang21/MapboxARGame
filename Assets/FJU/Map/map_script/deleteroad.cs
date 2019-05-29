using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteroad : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log("IEnumerator's still running");

        if (PoiMarkerHelper.markcheck == true)
        {
            Debug.Log("deleteroad : image's not active!!");
            if (gameObject.activeInHierarchy)
            {
                Destroy(gameObject);
            }
        }
        else if(PoiMarkerHelper.markcheck == false)
        {
            Debug.Log("deleteroad : image still exsist!!");
        }
        
    }
    
}