using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent : MonoBehaviour
{
    private GameObject waypoint;
    // Use this for initialization
    void Start()
    {
        var tran = GameObject.Find("Attribution").transform;
        waypoint = GameObject.Find("pinpoint");
        gameObject.transform.parent = tran;
    }
    public void OnBtn()
    {
        Debug.Log("destroy mark");
        PoiMarkerHelper.markcheck = true;
        Destroy(gameObject);
        Destroy(waypoint);
    }
}
