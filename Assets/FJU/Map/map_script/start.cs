using Mapbox.Unity.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

    [SerializeField]
    AbstractMap _map;

   public static  Vector3 _start;

    protected virtual void Awake()
    {
        if (_map == null)
        {
            _map = FindObjectOfType<AbstractMap>();
        }
    }

    // Update is called once per frame
    void Update ()
    {
        _start = ImmediatePositionWithLocationProvider.user_localpos;
        gameObject.GetComponent<Transform>().position = _start;
    }
}
