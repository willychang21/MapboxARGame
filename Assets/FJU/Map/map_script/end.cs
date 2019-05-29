using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
  
    public void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(PoiMarkerHelper.localpos.x, 5, PoiMarkerHelper.localpos.z);
    }

    public void Update()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(PoiMarkerHelper.localpos.x, 5, PoiMarkerHelper.localpos.z);
    }
    public void OnMouseUpAsButton()
    {
        Debug.Log("destroy mark");
        var marker = parent.deletemarker_for_end;
        var DirectionsClone = GameObject.Find("Directions(Clone)");
        var predict_panal = GameObject.Find("PredictPanel(Clone)");
        time_dis._dnameforglobal = null;
        PoiMarkerHelper.markcheck = true;
        Destroy(predict_panal);
        Destroy(gameObject);
        Destroy(marker);
        Destroy(DirectionsClone);
      
    }

 }

