using UnityEngine;
using Mapbox.Unity.MeshGeneration.Interfaces;
using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Data;
using UnityEngine.UI;
using Mapbox.Unity.MeshGeneration.Modifiers;

public class PoiMarkerHelper : MonoBehaviour, IFeaturePropertySettable
{

    Dictionary<string, object> _props;
    private markerpos _marker;
    private GameObject mapcam;
    private Camera cam;
    public static Vector3 screenPos;

    void Start()
    {
        FindCamera();
    }

    public void Set(Dictionary<string, object> props)
    {
        _props = props;


    }
    void FindCamera()
    {
        mapcam = GameObject.Find("MapCamera");
        cam = mapcam.GetComponent<Camera>();

    }



    public void OnMouseUpAsButton()
    {

        Debug.Log("mappos :"+gameObject.GetComponent<Transform>().position);
        Debug.Log("screenpos :"+cam.WorldToScreenPoint(gameObject.GetComponent<Transform>().position));
        screenPos = cam.WorldToScreenPoint(gameObject.GetComponent<Transform>().position);

        if (marker.markercheck >= 0)
        {
            Canvas canvas;
            var go = new GameObject("InteractiveSelectionCanvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            canvas = go.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            var sel = Instantiate(Resources.Load<GameObject>("selector"));
            sel.transform.SetParent(canvas.transform);
            _marker = sel.GetComponent<markerpos>();
            marker.markercheck++;
        }
        
        /*
        foreach (var prop in _props)
        {
            Debug.Log(prop.Key + ":" + prop.Value);
        }*/
    }



}
