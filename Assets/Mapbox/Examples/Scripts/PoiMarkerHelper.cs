using UnityEngine;
using Mapbox.Unity.MeshGeneration.Interfaces;
using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Data;
using UnityEngine.UI;
using Mapbox.Unity.MeshGeneration.Modifiers;
using System.Collections;

public class PoiMarkerHelper : MonoBehaviour, IFeaturePropertySettable
{
    [SerializeField]
    Image marker;

    [SerializeField]
    Camera _camera;

    Dictionary<string, object> _props;
    private GameObject mapcam;
 
    static public bool markcheck = true;
    static public bool update = true;
    static public GameObject image;
    static public Vector3 localpos;




    public void Set(Dictionary<string, object> props)
    {
        _props = props;
    }


    public void OnMouseUpAsButton()
    {
        localpos = gameObject.GetComponent<Transform>().position;

        Debug.Log("你觸擊到:"+gameObject.name);
        time_dis._dnameforglobal = gameObject.name;
        if (markcheck)
        {
            Instantiate(marker, _camera.WorldToScreenPoint(gameObject.GetComponent<Transform>().position), new Quaternion(0, 0, 0, 0));
            Instantiate(Resources.Load("Directions") as GameObject);
            Instantiate(Resources.Load("PredictPanel") as GameObject);
            markcheck = false; 
        }
    }

   






}
