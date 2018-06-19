using Mapbox.Unity.MeshGeneration.Data;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class markerpos : MonoBehaviour
{
    [SerializeField]
    private Transform _landmark;

    Vector3 landmarkpos = PoiMarkerHelper.screenPos;

    public void Update()
    {
        Debug.Log("markpos :" + landmarkpos);
        _landmark.transform.position = landmarkpos;
    }


}
