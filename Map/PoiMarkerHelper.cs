using UnityEngine;
using Mapbox.Unity.MeshGeneration.Interfaces;
using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Data;
using UnityEngine.UI;
using Mapbox.Unity.MeshGeneration.Modifiers;

public class PoiMarkerHelper : MonoBehaviour, IFeaturePropertySettable
{
	Dictionary<string, object> _props;
	private GameObject mapcam;
	private GameObject waypoint;
	private Camera cam;
	private Transform waypointrans;
	public Image marker;
	static public bool markcheck = true;


	void Start()
	{
		FindObject();
	}

	public void Set(Dictionary<string, object> props)
	{
		_props = props;


	}
	void FindObject()
	{
		mapcam = GameObject.Find("MapCamera");
		waypoint = GameObject.Find("pinpoint");		
		cam = mapcam.GetComponent<Camera>();
		waypointrans = waypoint.GetComponent<Transform>();
		

	}

	public void OnMouseUpAsButton()
	{
		Debug.Log("mappos :" + gameObject.GetComponent<Transform>().position);						
        foreach (var prop in _props)
        {
            Debug.Log(prop.Key + ":" + prop.Value);
        }
		if (markcheck)
		{
			Instantiate(marker, cam.WorldToScreenPoint(gameObject.GetComponent<Transform>().position), new Quaternion(0, 0, 0, 0));
			markcheck = false;
			if (waypoint.activeInHierarchy)
			{
				waypointrans.position = gameObject.GetComponent<Transform>().position;
			}
		}
	}



}
