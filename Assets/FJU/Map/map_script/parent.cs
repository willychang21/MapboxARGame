using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent : MonoBehaviour
{

    static public GameObject deletemarker_for_end;

    private GameObject DirectionsClone;
    Camera cam;

    private void Awake()
    {
        deletemarker_for_end = gameObject;
    }

    void Start()
    {
        var mapcam = GameObject.Find("MapCamera");       
        cam = mapcam.GetComponent<Camera>();      
        gameObject.transform.parent = _markeractive.tran;
        
    }
    public void OnBtn()
    {
        Debug.Log("destroy mark");
        time_dis._dnameforglobal = null;
        DirectionsClone = GameObject.Find("Directions(Clone)");
        PoiMarkerHelper.markcheck = true;
        var predict_panal = GameObject.Find("PredictPanel(Clone)");
        predictpanal_patent._pre_close.SetBool("pre_close", true);              
        Destroy(predict_panal);    
        Destroy(gameObject);
        Destroy(DirectionsClone);     
    }
    public void Update()
    {     
        gameObject.transform.position = cam.WorldToScreenPoint(PoiMarkerHelper.localpos);                      
    }
    
    }
